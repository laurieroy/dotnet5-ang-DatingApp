namespace API.Entities
{
  public class Photo
  {
    public int Id { get; set; }
    public string Url { get; set; }
    public bool Main { get; set; }
    public string PublicId { get; set; }
  }
}