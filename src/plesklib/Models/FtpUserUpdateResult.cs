namespace maestropanel.plesklib.Models
{
    using System.Xml.Serialization;

    [XmlRoot("packet")]
    public class FtpUserUpdateResult : IResponseResult
    {
        private ApiResponse _response;

        public FtpUserUpdateResult()
        {
            this._response = new ApiResponse();
            this.ftpUser = new FtpUserUpdateResultFtpUserNode();
        }

        [XmlElement("ftp-user")]
        public FtpUserUpdateResultFtpUserNode ftpUser { get; set; }

        public void SaveResult(ApiResponse response)
        {
            _response = response;
        }

        public ResponseResult ToResult()
        {
            this.ftpUser.set.result.apiResponse = _response;
            return this.ftpUser.set.result;
        }
    }

    public class FtpUserUpdateResultFtpUserNode
    {
        public FtpUserUpdateResultFtpUserNode()
        {
            this.set = new FtpUserUpdateResultAddNode();
        }

        [XmlElement("set")]
        public FtpUserUpdateResultAddNode set { get; set; }
    }

    public class FtpUserUpdateResultAddNode
    {
        public FtpUserUpdateResultAddNode()
        {
            this.result = new ResponseResult();
        }

        [XmlElement("result")]
        public ResponseResult result { get; set; }
    }

}
