using Microsoft.AspNetCore.Mvc;



namespace RestServisMimarisiPart1.Controllers
{
  // values controller yapılan tüm istekler /api/values endpoint ile yapılacaktır.
  // api da mvc de olduğu gibi {controller}/{action}/{id} route pattern tercih etmeyiz
  [Route("api/[controller]")]
  [ApiController]
  // Rest servis geliştiriken Controller isimlerini s takısı ile çoğul kullanam bir geliştirme standartıdır.
  public class ValuesController : ControllerBase
  {
    // GET: api/values
    // 
    [HttpGet]
    public IActionResult Get()
    {
      // OK ile status code 200 başarılı olarak sonuç döndük.
      // OK result içerisinde response içerir. 
      // api response'ları varsayılan olarak JSON formatına çevirir.
      var response = new string[] { "value1", "value2" };
      return Ok(response);
    }

    // GET api/values/1
    // HTTPGET yöntemi ile id 5 olan kaynağa istek attık
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
      var response = "value";
      // GET isteklerinde 200 OK status kod döndürmek bir geliştirme standartıdır.
      return Ok(response);
    }

    // POST api/values
    // HTTPPOST yöntemi ile yeni bir kaynak oluşturduk
    [HttpPost]
    public IActionResult Post([FromBody] string value)
    {
      var response = value;
      // Created Status Code 201 döner.
      // Yeni bir kaynak oluşturuken 201 durum kodu döndürmek bir geliştirme standartıdır.
      return Created("api/values", response); 
    }

    // PUT api/values/5
    // HTTPPUT yöntemi ile 5 numaralı kaydı güncellemek için istek attık.
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] string value)
    {
      // kaynak güncellemek için 204 NoContent durum kodu döndürmek bir geliştirme standartıdır
      return NoContent();
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      // kaynak silmek için 204 NoContent durum kodu döndürmek bir geliştirme standartıdır
      return NoContent();
    }
  }
}
