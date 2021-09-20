using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HobbyRadarAPI.Data;
using HobbyRadarAPI.Models;
using MimeKit;
using MailKit.Net.Smtp;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace HobbyRadarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalInvitationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ExternalInvitationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ExternalInvitations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExternalInvitation>>> GetExternalInvitations()
        {
            return await _context.ExternalInvitation.ToListAsync();
        }
        
        // GET: api/ExternalInvitations
        [HttpGet("user")]
        public async Task<ActionResult<IEnumerable<ExternalInvitation>>> GetExternalInvitationsByUser([FromBody] string userId)
        {
            bool userExists = _context.Users.Any(u => u.Id == userId);
            if (!userExists)
            {
                return BadRequest();
            }
            List<ExternalInvitation> userInvites = _context.ExternalInvitations.Where(ei => ei.FromUserId == userId).ToList();

            return Ok(userInvites);
        }

        // GET: api/ExternalInvitations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExternalInvitation>> GetExternalInvitation(int id)
        {
            var externalInvitation = await _context.ExternalInvitation.FindAsync(id);

            if (externalInvitation == null)
            {
                return NotFound();
            }

            return externalInvitation;
        }

        // PUT: api/ExternalInvitations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExternalInvitation(int id, ExternalInvitation externalInvitation)
        {
            if (id != externalInvitation.ExternalInvitationId)
            {
                return BadRequest();
            }

            _context.Entry(externalInvitation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExternalInvitationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ExternalInvitations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ExternalInvitation>> PostExternalInvitation(ExternalInvitation externalInvitation)
        {
            _context.ExternalInvitation.Add(externalInvitation);
            await _context.SaveChangesAsync();

            SendInvitation(externalInvitation);

            return CreatedAtAction("GetExternalInvitation", new { id = externalInvitation.ExternalInvitationId }, externalInvitation);
        }

        // DELETE: api/ExternalInvitations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExternalInvitation(int id)
        {
            var externalInvitation = await _context.ExternalInvitation.FindAsync(id);
            if (externalInvitation == null)
            {
                return NotFound();
            }

            _context.ExternalInvitation.Remove(externalInvitation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExternalInvitationExists(int id)
        {
            return _context.ExternalInvitation.Any(e => e.ExternalInvitationId == id);
        }

        private void SendInvitation(ExternalInvitation ei)
        {
            User fromUser = _context.Users.Find(ei.FromUserId);
            string fromUserName = $"{fromUser.FirstName} {fromUser.LastName.Substring(0, 1)}.";

            switch (ei.ContactMethod)
            {
                case "email":
                    SendEmail(ei.Name, ei.ContactInfo, fromUserName);
                    break;
                case "text":
                    SendSms(ei.Name, ei.ContactInfo, fromUserName);
                    break;
                default:
                    break;
            }
        }

        private void SendEmail(string name, string email, string fromName)
        {
            Private privateInfo = new Private();
            var mailMessage = new MimeMessage();
            mailMessage.From.Add(new MailboxAddress("Hobby Radar", privateInfo.Email));
            mailMessage.To.Add(new MailboxAddress(name, email));
            mailMessage.Subject = $"{fromName} has invited you to join Hobby Radar!";
            mailMessage.Body = new TextPart("plain") { Text = "Join here: https://www.hobbyradar.com" };

            using (var smtpClient = new SmtpClient())
            {

                smtpClient.Connect(privateInfo.Host, privateInfo.Port, true);
                smtpClient.Authenticate(privateInfo.Email, privateInfo.Password);
                smtpClient.Send(mailMessage);
                smtpClient.Disconnect(true);
            }
        }

        private void SendSms(string name, string phone, string fromName)
        {
            Private privateInfo = new Private();
            string accountSid = privateInfo.AccountSid;
            string authToken = privateInfo.AuthToken;

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: $"Hello {name}, {fromName} invited you to join Hobby Radar! Join here: https://www.hobbyradar.com",
                from: new Twilio.Types.PhoneNumber("+15754689191"),
                to: new Twilio.Types.PhoneNumber(phone)
            );
        }
    }
}
