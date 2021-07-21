using maestropanel.plesklib.Models;
using System.Collections.Generic;

namespace maestropanel.plesklib
{
    public interface IPleskClient
    {
        ResponseResult AddFtpAccount(string domain, string username, string password, string home, int quota, bool CreateDirectory, bool AllowRead = true, bool AllowWrite = true);
        ResponseResult ChangeDatabaseUserPassword(string name, string databaseName, string username, string newpassword);
        ResponseResult ChangeVirtualDirecotry(string name, string virtualDirectoryName, bool enableParentPaths);
        ResponseResult ConnectionTest();
        ResponseResult CreateAlias(int siteId, string name, bool enableWeb = true, bool enableMail = false, bool enableTomcat = false, bool seoredirect = false);
        ResponseResult CreateAlias(string name, string aliasName, bool enableWeb = true, bool enableMail = false, bool enableTomcat = false, bool seoredirect = false);
        ResponseResult CreateCustomer(string username, string password, string email, string fullName, string company, string address, string phone, string fax, string city, string state, string postalCode, string country);
        ResponseResult CreateDatabase(string name, string databaseName, string databaseType);
        ResponseResult CreateDatabaseUser(string name, string databaseName, string username, string password, string passwordType = "plain", string role = "readWrite");
        ResponseResult CreateProtectedDir(int siteId, string name, string headerText, bool ssl = false, bool nonssl = false, bool cgi = false);
        ResponseResult CreateProtectedDirUser(int pdid, string username, string password, string passwordType = "plain");
        ResponseResult CreateSite(int webspaceId, string name, List<HostingProperty> properties);
        ResponseResult CreateSubdomain(string parent, string name);
        ResponseResult CreateSubdomain(string parent, string name, string homedir);
        ResponseResult CreateSubdomain(string parent, string name, string homedir, string ftpusername, string ftppassword, bool ssi = false, bool ssiHtml = false);
        ResponseResult CreateVirtualDirectory(string name, string virtualDirectoryName, string physichalPath = "", bool convertApplication = false);
        ResponseResult CreateWebSpace(string name, string ipaddr);
        ResponseResult CreateWebSpace(string name, string ipaddr, List<HostingProperty> properties);
        ResponseResult CreateWebSpace(string name, string ipaddr, string planName, List<HostingProperty> properties);
        ResponseResult CreateWebSpace(string customerName, string name, string ipaddr, string planName);
        ResponseResult CreateWebSpace(string owner, string name, string ipaddr, string username, string password, List<HostingProperty> properties);
        ResponseResult CreateWebSpace(string customerName, string name, string ipaddr, string planName, string ftpusername, string ftppassword);
        ResponseResult CreateWebSpace(string customerName, string name, string ipaddr, string planName, string ftpusername, string ftppassword, List<HostingProperty> properties);
        ResponseResult DeleteAlias(string name);
        ResponseResult DeleteDatabase(string name, string databaseName);
        ResponseResult DeleteDatabaseUser(string name, string databaseName, string username);
        ResponseResult DeleteFtpAccount(string webspaceName, string username);
        ResponseResult DeleteSite(string name);
        ResponseResult DeleteSubdomain(string name);
        ResponseResult DeleteVirtualDirectory(string name, string virtualDirectoryName);
        ResponseResult DeleteWebSpace(string name);
        T DeSerializeObject<T>(string xmlString);
        FtpUserGetAllResult GetAllFtpAccounts(int webspaceId = 1);
        DatabaseGetResult GetDatabaseList(string name);
        DatabaseUserGetResult GetDatabaseUserList(string name, string databaseName);
        FtpUserGetResult GetFtpAccount(int accountId = 0);
        IPAddrGetResult GetIPAddressList();
        ServicePlanItem[] GetServicePlans();
        SiteGetResult GetSite(string name);
        WebSpaceGetResult GetWebSpace(string name);
        string SerializeObjectToXmlString<T>(T TModel);
        ResponseResult SetDefaultDocs(string name, string virtualDirectoryName, string[] docs);
        FtpUserUpdateResult UpdateFtpAccount(int userId, string homedir = "", FtpUserGetPermissions permissions = null);
        FtpUserUpdateResult UpdateFtpAccount(string ftpName, string homedir = "", FtpUserGetPermissions permissions = null);
    }
}