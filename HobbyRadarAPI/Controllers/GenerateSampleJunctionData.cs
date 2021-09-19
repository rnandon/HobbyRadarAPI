using HobbyRadarAPI.Data;
using HobbyRadarAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HobbyRadarAPI.Controllers
{
    [Route("api/sampledata")]
    [ApiController]
    public class GenerateSampleJunctionData : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GenerateSampleJunctionData(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GenerateSampleData()
        {
            List<Hobby> allHobbies = _context.Hobbies.ToList();
            List<Tag> allTags = _context.Tags.ToList();

            Hobby currentHobby = allHobbies.Where(ah => ah.Name == "3D PRINTING").FirstOrDefault();
            Tag currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            HobbyTag newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "HIGH TECH").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "ACTING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "HIGH TECH").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "AIRBRUSHING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "URBAN").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHYSICAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WEATHER DEPENDENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXERCISE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "AMATEUR RADIO").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PERFORMANCE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "HIGH TECH").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "URBAN").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "MUSIC").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHILANTHROPY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EDUCATIONAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "ANIMATION").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "HIGH TECH").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "ANIME").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "ASTROLOGY").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NO EQUIPMENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "BAKING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHILANTHROPY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FOOD & DRINK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "BINGE-WATCHING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "BLOGGING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "HIGH TECH").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EDUCATIONAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "BOARD GAMES").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NO EQUIPMENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "BOOK CLUBS").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NO EQUIPMENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COLLECTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EDUCATIONAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "BOWLING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PERFORMANCE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SPORT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHYSICAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FOOD & DRINK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXERCISE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "CALLIGRAPHY").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "CARD GAMES").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "COFFEE ROASTING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FOOD & DRINK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "COLLECTING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NO EQUIPMENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "HIGH TECH").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NATURE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "URBAN").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "MUSIC").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FOOD & DRINK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COLLECTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EDUCATIONAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WEATHER DEPENDENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "COLORING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "CODING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "HIGH TECH").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EDUCATIONAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "CARPENTRY").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHYSICAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "COOKING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FOOD & DRINK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WEATHER DEPENDENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "COSPLAYING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PERFORMANCE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COLLECTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "WRITING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NO EQUIPMENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EDUCATIONAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "CROCHETING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EDUCATIONAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "CROSS-STITCH").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "CROSSWORD PUZZLES").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NO EQUIPMENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EDUCATIONAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "DANCE").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NO EQUIPMENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PERFORMANCE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SPORT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "MUSIC").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHYSICAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXERCISE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "DECORATING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COLLECTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXERCISE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "DIGITAL ARTS").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "HIGH TECH").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "DIVING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXTREME").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PERFORMANCE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SPORT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NATURE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WATER").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WET").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WEATHER DEPENDENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXERCISE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "DJ-ING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PERFORMANCE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "HIGH TECH").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "MUSIC").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHYSICAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WEATHER DEPENDENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "DRAWING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "DRINK MIXING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PERFORMANCE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FOOD & DRINK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WATER").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WET").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "VIDEO GAMES").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PERFORMANCE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SPORT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "HIGH TECH").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EDUCATIONAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "ELECTRONICS").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "HIGH TECH").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EDUCATIONAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "EMBROIDERY").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "ENGRAVING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WET").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WEATHER DEPENDENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXERCISE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "FANTASY SPORTS").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NO EQUIPMENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SPORT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EDUCATIONAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "FASHION DESIGN").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PERFORMANCE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXERCISE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "FILMMAKING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PERFORMANCE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WEATHER DEPENDENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "FISHKEEPING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ANIMALS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NATURE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COLLECTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EDUCATIONAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WATER").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WET").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "FLOWER ARRANGING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NO EQUIPMENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NATURE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHYSICAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "FLY TYING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SPORT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NATURE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COLLECTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WATER").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "LANGUAGE LEARNING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NO EQUIPMENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EDUCATIONAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "GENEALOGY").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NO EQUIPMENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "GLASSBLOWING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PERFORMANCE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHYSICAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "GARDENING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NATURE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FOOD & DRINK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHYSICAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EDUCATIONAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WET").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WEATHER DEPENDENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXERCISE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "GRAPHIC DESIGN").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "HIGH TECH").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "GUNSMITHING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SPORT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHYSICAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "HACKING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "HIGH TECH").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EDUCATIONAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "REPTILE KEEPING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ANIMALS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NATURE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COLLECTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EDUCATIONAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "HOME IMPROVEMENT").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHYSICAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WEATHER DEPENDENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "CRAFT BEER BREWING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FOOD & DRINK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EDUCATIONAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WATER").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WET").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "HYDROPONICS").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "HIGH TECH").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NATURE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FOOD & DRINK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WATER").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WET").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "ICE SKATING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PERFORMANCE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SPORT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NATURE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHYSICAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WEATHER DEPENDENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXERCISE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "SKATING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PERFORMANCE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SPORT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NATURE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "URBAN").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHYSICAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WEATHER DEPENDENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXERCISE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "SOLVING PUZZLES").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NO EQUIPMENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "JOURNALING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "JUGGLING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXTREME").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PERFORMANCE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SPORT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHYSICAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXERCISE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "KARAOKE").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NO EQUIPMENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PERFORMANCE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "MUSIC").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "MARTIAL ARTS").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXTREME").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SPORT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHYSICAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXERCISE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "KNIFE MAKING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COLLECTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "KNITTING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "BREWING KOMBUCHA").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FOOD & DRINK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "LEATHERCRAFTING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "LAPIDARY").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NATURE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHYSICAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COLLECTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "LEGO BUILDING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COLLECTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "LIVE STREAMING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PERFORMANCE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "HIGH TECH").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "LISTENING TO MUSIC").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "MUSIC").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COLLECTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "LISTENING TO PODCASTS").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "MUSIC").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EDUCATIONAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "LOCKPICKING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COLLECTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "MACHINING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHYSICAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "MACRAME").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "MAGIC").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NO EQUIPMENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PERFORMANCE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHYSICAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "MAKEUP ARTISTRY").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "URBAN").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "MANGA").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NO EQUIPMENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COLLECTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "MASSAGE").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NO EQUIPMENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHYSICAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "MAZES").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NO EQUIPMENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NATURE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "URBAN").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WEATHER DEPENDENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "ESCAPE ROOMS").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NO EQUIPMENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "URBAN").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "MECHANICS").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHYSICAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COLLECTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "MEDITATION").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NO EQUIPMENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NATURE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "URBAN").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "MUSIC").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "METALWORKING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHYSICAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXERCISE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "MINIATURE ART").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "MODEL BUILDING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "PLAYING AN INSTRUMENT").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PERFORMANCE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NATURE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "URBAN").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "MUSIC").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WEATHER DEPENDENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "PAINTING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ANIMALS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NATURE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "URBAN").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHILANTHROPY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHYSICAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COLLECTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EDUCATIONAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "PALMISTRY").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NO EQUIPMENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PERFORMANCE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "PET SITTING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NO EQUIPMENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ANIMALS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NATURE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "URBAN").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "BABY SITTING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NO EQUIPMENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHILANTHROPY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHYSICAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "PHOTOGRAPHY").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "HIGH TECH").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ANIMALS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NATURE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "URBAN").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHILANTHROPY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHYSICAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COLLECTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WEATHER DEPENDENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXCITING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "POETRY").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NO EQUIPMENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PERFORMANCE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "POI").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXTREME").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PERFORMANCE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SPORT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PHYSICAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "POTTERY").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "WET").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "QUILTING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COLLECTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "DRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "QUIZZES").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CHALLENGING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EDUCATIONAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "RC VEHICLES").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EQUIPMENT NEEDED").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COSTS MONEY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "EXTREME").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SPORT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CRAFTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "HIGH TECH").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COLLECTING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "RAPPING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COOPERATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "COMPETITIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "NO EQUIPMENT").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SELLABLE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "PERFORMANCE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "MUSIC").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "INTELLECTUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW RISK").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOCIAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentHobby = allHobbies.Where(ah => ah.Name == "READING").FirstOrDefault();
            currentTag = allTags.Where(t => t.Name == "INDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "OUTDOORS").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "SOLO").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "GROUP").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CASUAL").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "FREE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "LOW BARRIER TO ENTRY").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "ART").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "CREATIVE").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);

            currentTag = allTags.Where(t => t.Name == "RELAXING").FirstOrDefault();
            newHobbyTag = new HobbyTag() { HobbyId = currentHobby.HobbyId, TagId = currentTag.TagId };
            _context.HobbyTags.Add(newHobbyTag);


            _context.SaveChanges();

            return Ok();
        }
    }
}
