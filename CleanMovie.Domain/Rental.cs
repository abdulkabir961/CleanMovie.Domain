namespace CleanMovie.Domain
{
    public class Rental
    {
        public int RentalId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime RentalExpire { get; set; }
        public decimal TotalCost { get; set; }
        //One-to-Many relationship
        public ICollection<Member> Member { get; set; }
        //Linking Many-to-many relationship
        public IList<MovieRental> MovieRentals { get; set; }

    }
}