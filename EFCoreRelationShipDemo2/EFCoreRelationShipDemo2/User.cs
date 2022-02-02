namespace EFCoreRelationShipDemo2
{
    public class User
    {
        public int  Id { get; set; }
        public string UserName { get; set; } = string.Empty;

        //Navigation Property
        public List<FavCharacterOfUser> FavCharacterOfUser { get; set; }
}
}
