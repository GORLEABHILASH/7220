
using Microsoft.AspNetCore.Mvc;
using YourNamespace.Models;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SongController : ControllerBase
    {
        [HttpGet("song1")]
        public IActionResult GetSongLyrics1()
        {
            // Placeholder for fetching song lyrics logic
            var song = new SongLyrics
            {
                Title = "Country Roads - John Denver",
                Lyrics = "<div style=' font-family: monospace; white-space: pre;'>" +
                        "[Verse 1]<br>" + 
                        "Almost heaven, West Virginia<br>" +
                        "Blue Ridge Mountains, Shenandoah River<br>" +
                        "Life is old there, older than the trees<br>" +
                        "Younger than the mountains, blowing like a breeze<br>" +
                        "<br>" +
                        "[Chorus]<br>" +
                        "Country roads, take me home<br>" +
                        "To the place I belong<br>" +
                        "West Virginia, mountain mama<br>" +
                        "Take me home, country roads<br>" +
                        "<br>" +
                        "</div>"
            };
            return Ok(song);
        }



        [HttpGet("song2")]
        public IActionResult GetSongLyrics2()
        {
            // Placeholder for fetching song lyrics logic
            var song = new SongLyrics
            {
                Title = "Tu - Vasu Raina",
                Lyrics = "Tu<br>Bas ek tu..<br>Tune sikhaya" + 
                " mujhe<br>Hasna yu..<br><br>Hmm..<br>Tu<br>Han ek tu..<br>Tune sawara mujhe jab<br>Tha main tanha" +
                " yu..<br><br>Adhoora tha main har ghadi<br>Apne me hi<br>Karta tha main guftagu<br>Karte karte guftagu<br>Mila" +
                " tujhse hu<br>Kese kab kyu ye kya main kahu...<br><br>Ohh hoo wo<br>Tu hi hai<br>Jo mere sath chalta hai<br>Ohh" +
                " hoo wo<br>Tu hi hai, woo<br>Ohh hoo wo<br>Tu hi hai<br>Jo mere sath chalta hai<br>Ohh hooo<br>Tu hi hai, woo<br>"
            };
            return Ok(song);
        }


        
        [HttpGet("song3")]
        public IActionResult GetSongLyrics3()
        {
            // Placeholder for fetching song lyrics logic
            var song = new SongLyrics
            {
                Title = "Illuminati - Sushin Shyam",
                Lyrics ="<span>Naadin Nanmakane<br></span><span>Ponmakane Muthaayavane" +
                "<br></span><span>Minnum Sooriyanum <br></span><span>Chanthiranum Onnaayavane<br></span>" +
                "<span>Thaaraavum Neeravum<br></span><span>Thaazhvarayum Thaazhvarayum<br></span><span>Thaazhvarayum" +
                " Thaazhvarayum<br></span><span>Thaazhvarayum Thaazhvarayum<br></span><span>Thaazhvarayum Thaazhvarayum<br></span>"
            };
            return Ok(song);
        }





    }
}
