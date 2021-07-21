namespace maestropanel.plesklib.TestModels
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class packet
    {

        private packetFtpuser ftpuserField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ftp-user")]
        public packetFtpuser ftpuser
        {
            get
            {
                return this.ftpuserField;
            }
            set
            {
                this.ftpuserField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class packetFtpuser
    {

        private packetFtpuserSet setField;

        /// <remarks/>
        public packetFtpuserSet set
        {
            get
            {
                return this.setField;
            }
            set
            {
                this.setField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class packetFtpuserSet
    {

        private packetFtpuserSetFilter filterField;

        private packetFtpuserSetValues valuesField;

        /// <remarks/>
        public packetFtpuserSetFilter filter
        {
            get
            {
                return this.filterField;
            }
            set
            {
                this.filterField = value;
            }
        }

        /// <remarks/>
        public packetFtpuserSetValues values
        {
            get
            {
                return this.valuesField;
            }
            set
            {
                this.valuesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class packetFtpuserSetFilter
    {

        private byte idField;

        /// <remarks/>
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class packetFtpuserSetValues
    {

        private string homeField;

        private bool createnonexistentField;

        private packetFtpuserSetValuesPermissions permissionsField;

        /// <remarks/>
        public string home
        {
            get
            {
                return this.homeField;
            }
            set
            {
                this.homeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("create-non-existent")]
        public bool createnonexistent
        {
            get
            {
                return this.createnonexistentField;
            }
            set
            {
                this.createnonexistentField = value;
            }
        }

        /// <remarks/>
        public packetFtpuserSetValuesPermissions permissions
        {
            get
            {
                return this.permissionsField;
            }
            set
            {
                this.permissionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class packetFtpuserSetValuesPermissions
    {

        private bool readField;

        private bool writeField;

        /// <remarks/>
        public bool read
        {
            get
            {
                return this.readField;
            }
            set
            {
                this.readField = value;
            }
        }

        /// <remarks/>
        public bool write
        {
            get
            {
                return this.writeField;
            }
            set
            {
                this.writeField = value;
            }
        }
    }


}
