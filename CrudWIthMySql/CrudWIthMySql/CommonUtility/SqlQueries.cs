namespace CrudWIthMySql.CommonUtility
{
    public class SqlQueries
    {
        public static IConfiguration _configuration = new ConfigurationBuilder().AddXmlFile("SqlQueries.xml",true,true).Build();
        public static string AddInformation { get  { return _configuration["AddInformation"]; } }
        public static string ReadAllInformation { get { return _configuration["ReadAllInformation"]; } }
        public static string UpdateInformation { get { return _configuration["UpdateAllInformation"]; } }
        public static string DeleteInformation { get { return _configuration["DeleteInformation"]; } }
        public static string GetAllDeleteInformation { get { return _configuration["GetAllDeleteInformation"]; } }
    }
}
