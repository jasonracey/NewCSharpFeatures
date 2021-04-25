namespace ConsoleUI
{
    public class PersonModel
    {
        public string Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public PersonModel()
        {

        }

        public PersonModel(string id, string firstName, string lastname)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastname;
        }
    }
}
