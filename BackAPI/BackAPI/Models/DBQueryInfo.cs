namespace BackAPI.Models
{
    public class DBQueryInfo : DBInfo
    {
        public string SelectedTable { get; set; }
        public string SelectedColumnX { get; set; }  // X ekseni için kolon
        public string SelectedColumnY { get; set; }  // Y ekseni için kolon
    }
}
