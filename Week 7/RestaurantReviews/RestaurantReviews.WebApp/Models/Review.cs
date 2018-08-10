namespace RestaurantReviews.WebApp.Models
{
    public class Review
    {
        public string ReviewerName { get; set; }
        public int? Score { get; set; }
        public string Text { get; set; }
    }
}