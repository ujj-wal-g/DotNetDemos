namespace EFCoreRelationShipDemo2
{
    public class FavCharacterOfUser
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string charClass { get; set; } = "Knight";
        
        //Navigation Properties
        public User User { get; set; }
        public int UserId  { get; set; }
    }
}
