namespace RealEstate_Dapper_Api.Dtos.TestimonialDtos
{
    public class UpdateTestimonialDto
    {
        public int testimonialID { get; set; }
        public string nameSurname { get; set; }
        public string title { get; set; }
        public string comment { get; set; }
        public bool status { get; set; }
    }
}
