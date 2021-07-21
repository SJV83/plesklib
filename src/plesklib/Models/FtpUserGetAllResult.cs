using maestropanel.plesklib.Models;
using System.Xml.Serialization;


// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[XmlRoot("packet")]
public partial class FtpUserGetAllResult
{
    [XmlAttribute("version")]
    public string Version { get; set; }

    /// <remarks/>
    [XmlElement("ftp-user")]
    public packetFtpuser ftpuser { get; set; }
}

public partial class packetFtpuser
{
    /// <remarks/>
    [XmlArray("get")]
    [XmlArrayItem("result", IsNullable = false)]
    public packetFtpuserResult[] Results { get; set; }
}

public partial class packetFtpuserResult
{
    /// <remarks/>
    public string status { get; set; }

    /// <remarks/>
    [XmlElement("filter-id")]
    public byte filterid { get; set; }

    /// <remarks/>
    public int id { get; set; }

    /// <remarks/>
    public string name { get; set; }

    /// <remarks/>
    public string home { get; set; }
    public string quota { get; set; }
    public FtpUserGetPermissions permissions { get; set; }

    /// <remarks/>
    [XmlElement("webspace-id")]
    public byte webspaceid { get; set; }
}



//namespace maestropanel.plesklib.Models
//{

//    [XmlRoot("packet")]
//    public class FtpUserGetAllResult : IResponseResult
//    {
//        private ApiResponse _response;

//        public FtpUserGetAllResult()
//        {
//            this._response = new ApiResponse();
//            this.ftpUser = new FtpUserGetResultFtpUserNode();
//        }

//        [XmlElement("ftp-user")]
//        public FtpUserGetResultFtpUserNode ftpUser { get; set; }

//        public void SaveResult(ApiResponse response)
//        {
//            _response = response;
//        }

//        public ResponseResult ToResult()
//        {
//            var result = new ResponseResult();
//            result.apiResponse = _response;
//            result.Id = this.ftpUser.get.Result.id.ToString();
//            return result;
//        }
//    }

//    public class FtpUserGetAllResultFtpUserNode
//    {
//        [XmlElement("get")]
//        public FtpUserGetResultGetNode AllFtpUsers { get; set; }
//    }

//    public class FtpUserGetAllResultsNode
//    {
//        public FtpUserGetAllResultsNode()
//        {
//            Result = Enumerable.Empty<FtpUserGetAllResultNode>().ToArray();
//        }

//        [XmlArray("result")]
//        public FtpUserGetAllResultNode[] Result { get; set; }
//    }

//    public class FtpUserGetAllResultNode
//    {
//        public FtpUserGetAllResultNode()
//        {
//            //permissions = new FtpUserGetPermissions();
//        }

//        [XmlArrayItem("status")]
//        public string status { get; set; }

//        //[XmlElement("filter-id")]
//        //public int filterId { get; set; }

//        //[XmlElement("id")]
//        //public int id { get; set; }

//        //[XmlElement("name")]
//        //public string name { get; set; }

//        //[XmlElement("home")]
//        //public string home { get; set; }

//        //[XmlElement("quota")]
//        //public string quota { get; set; }

//        //[XmlElement("permissions")]
//        //public FtpUserGetPermissions permissions { get; set; }

//        //[XmlElement("webspace-id")]
//        //public int webspaceId { get; set; }
//    }
//}
