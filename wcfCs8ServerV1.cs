﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Staubli.Robotics.Soap.Proxies.ServerV1
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
    [System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
    public partial class ServerException : object, System.Xml.Serialization.IXmlSerializable
    {
        
        private System.Xml.XmlNode[] nodesField;
        
        private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("ServerException", "CS8ServerV0");
        
        public System.Xml.XmlNode[] Nodes
        {
            get
            {
                return this.nodesField;
            }
            set
            {
                this.nodesField = value;
            }
        }
        
        public void ReadXml(System.Xml.XmlReader reader)
        {
            this.nodesField = System.Runtime.Serialization.XmlSerializableServices.ReadNodes(reader);
        }
        
        public void WriteXml(System.Xml.XmlWriter writer)
        {
            System.Runtime.Serialization.XmlSerializableServices.WriteNodes(writer, this.Nodes);
        }
        
        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }
        
        public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
        {
            System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
            return typeName;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:CS8ServerV1", ConfigurationName="Staubli.Robotics.Soap.Proxies.ServerV1.CS8ServerV1PortType")]
    public interface CS8ServerV1PortType
    {
        
        // CODEGEN: Generating message contract since message getApplicationsRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Staubli.Robotics.Soap.Proxies.ServerV1.ServerException), Action="", Name="ServerException", Namespace="CS8ServerV0")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        Staubli.Robotics.Soap.Proxies.ServerV1.getApplicationsResponse getApplications(Staubli.Robotics.Soap.Proxies.ServerV1.getApplicationsRequest request);
        
        // CODEGEN: Generating message contract since message getApplicationDatasRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Staubli.Robotics.Soap.Proxies.ServerV1.ServerException), Action="", Name="ServerException", Namespace="CS8ServerV0")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        Staubli.Robotics.Soap.Proxies.ServerV1.getApplicationDatasResponse getApplicationDatas(Staubli.Robotics.Soap.Proxies.ServerV1.getApplicationDatasRequest request);
        
        // CODEGEN: Generating message contract since message getRecordsRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Staubli.Robotics.Soap.Proxies.ServerV1.ServerException), Action="", Name="ServerException", Namespace="CS8ServerV0")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        Staubli.Robotics.Soap.Proxies.ServerV1.getRecordsResponse getRecords(Staubli.Robotics.Soap.Proxies.ServerV1.getRecordsRequest request);
        
        // CODEGEN: Generating message contract since message getRecordRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Staubli.Robotics.Soap.Proxies.ServerV1.ServerException), Action="", Name="ServerException", Namespace="CS8ServerV0")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        Staubli.Robotics.Soap.Proxies.ServerV1.getRecordResponse getRecord(Staubli.Robotics.Soap.Proxies.ServerV1.getRecordRequest request);
        
        // CODEGEN: Generating message contract since message getJointRangeRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Staubli.Robotics.Soap.Proxies.ServerV1.ServerException), Action="", Name="ServerException", Namespace="CS8ServerV0")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        Staubli.Robotics.Soap.Proxies.ServerV1.getJointRangeResponse getJointRange(Staubli.Robotics.Soap.Proxies.ServerV1.getJointRangeRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:CS8ServerV1")]
    public partial class VALApplication
    {
        
        private string nameField;
        
        private bool loadedField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=0)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public bool loaded
        {
            get
            {
                return this.loadedField;
            }
            set
            {
                this.loadedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:CS8ServerV1")]
    public partial class JointRange
    {
        
        private double[] minField;
        
        private double[] maxField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("min", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public double[] min
        {
            get
            {
                return this.minField;
            }
            set
            {
                this.minField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("max", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public double[] max
        {
            get
            {
                return this.maxField;
            }
            set
            {
                this.maxField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getApplications", WrapperNamespace="urn:CS8ServerV1", IsWrapped=true)]
    public partial class getApplicationsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="CS8ServerV0")]
        public int sessionId;
        
        public getApplicationsRequest()
        {
        }
        
        public getApplicationsRequest(int sessionId)
        {
            this.sessionId = sessionId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getApplicationsResponse", WrapperNamespace="urn:CS8ServerV1", IsWrapped=true)]
    public partial class getApplicationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:CS8ServerV1", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("application", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public VALApplication[] applications;
        
        public getApplicationsResponse()
        {
        }
        
        public getApplicationsResponse(VALApplication[] applications)
        {
            this.applications = applications;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getApplicationDatas", WrapperNamespace="urn:CS8ServerV1", IsWrapped=true)]
    public partial class getApplicationDatasRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="CS8ServerV0")]
        public int sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:CS8ServerV1", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string name;
        
        public getApplicationDatasRequest()
        {
        }
        
        public getApplicationDatasRequest(int sessionId, string name)
        {
            this.sessionId = sessionId;
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getApplicationDatasResponse", WrapperNamespace="urn:CS8ServerV1", IsWrapped=true)]
    public partial class getApplicationDatasResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:CS8ServerV1", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary")]
        public byte[] data;
        
        public getApplicationDatasResponse()
        {
        }
        
        public getApplicationDatasResponse(byte[] data)
        {
            this.data = data;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getRecords", WrapperNamespace="urn:CS8ServerV1", IsWrapped=true)]
    public partial class getRecordsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="CS8ServerV0")]
        public int sessionId;
        
        public getRecordsRequest()
        {
        }
        
        public getRecordsRequest(int sessionId)
        {
            this.sessionId = sessionId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getRecordsResponse", WrapperNamespace="urn:CS8ServerV1", IsWrapped=true)]
    public partial class getRecordsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:CS8ServerV1", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("record", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public string[] records;
        
        public getRecordsResponse()
        {
        }
        
        public getRecordsResponse(string[] records)
        {
            this.records = records;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getRecord", WrapperNamespace="urn:CS8ServerV1", IsWrapped=true)]
    public partial class getRecordRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="CS8ServerV0")]
        public int sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:CS8ServerV1", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string name;
        
        public getRecordRequest()
        {
        }
        
        public getRecordRequest(int sessionId, string name)
        {
            this.sessionId = sessionId;
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getRecordResponse", WrapperNamespace="urn:CS8ServerV1", IsWrapped=true)]
    public partial class getRecordResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:CS8ServerV1", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary")]
        public byte[] data;
        
        public getRecordResponse()
        {
        }
        
        public getRecordResponse(byte[] data)
        {
            this.data = data;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getJointRange", WrapperNamespace="urn:CS8ServerV1", IsWrapped=true)]
    public partial class getJointRangeRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="CS8ServerV0")]
        public int sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:CS8ServerV1", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int robot;
        
        public getJointRangeRequest()
        {
        }
        
        public getJointRangeRequest(int sessionId, int robot)
        {
            this.sessionId = sessionId;
            this.robot = robot;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getJointRangeResponse", WrapperNamespace="urn:CS8ServerV1", IsWrapped=true)]
    public partial class getJointRangeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:CS8ServerV1", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Staubli.Robotics.Soap.Proxies.ServerV1.JointRange range;
        
        public getJointRangeResponse()
        {
        }
        
        public getJointRangeResponse(Staubli.Robotics.Soap.Proxies.ServerV1.JointRange range)
        {
            this.range = range;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface CS8ServerV1PortTypeChannel : Staubli.Robotics.Soap.Proxies.ServerV1.CS8ServerV1PortType, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class CS8ServerV1PortTypeClient : System.ServiceModel.ClientBase<Staubli.Robotics.Soap.Proxies.ServerV1.CS8ServerV1PortType>, Staubli.Robotics.Soap.Proxies.ServerV1.CS8ServerV1PortType
    {
        
        public CS8ServerV1PortTypeClient()
        {
        }
        
        public CS8ServerV1PortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public CS8ServerV1PortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public CS8ServerV1PortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public CS8ServerV1PortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Staubli.Robotics.Soap.Proxies.ServerV1.getApplicationsResponse Staubli.Robotics.Soap.Proxies.ServerV1.CS8ServerV1PortType.getApplications(Staubli.Robotics.Soap.Proxies.ServerV1.getApplicationsRequest request)
        {
            return base.Channel.getApplications(request);
        }
        
        public VALApplication[] getApplications(int sessionId)
        {
            Staubli.Robotics.Soap.Proxies.ServerV1.getApplicationsRequest inValue = new Staubli.Robotics.Soap.Proxies.ServerV1.getApplicationsRequest();
            inValue.sessionId = sessionId;
            Staubli.Robotics.Soap.Proxies.ServerV1.getApplicationsResponse retVal = ((Staubli.Robotics.Soap.Proxies.ServerV1.CS8ServerV1PortType)(this)).getApplications(inValue);
            return retVal.applications;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Staubli.Robotics.Soap.Proxies.ServerV1.getApplicationDatasResponse Staubli.Robotics.Soap.Proxies.ServerV1.CS8ServerV1PortType.getApplicationDatas(Staubli.Robotics.Soap.Proxies.ServerV1.getApplicationDatasRequest request)
        {
            return base.Channel.getApplicationDatas(request);
        }
        
        public byte[] getApplicationDatas(int sessionId, string name)
        {
            Staubli.Robotics.Soap.Proxies.ServerV1.getApplicationDatasRequest inValue = new Staubli.Robotics.Soap.Proxies.ServerV1.getApplicationDatasRequest();
            inValue.sessionId = sessionId;
            inValue.name = name;
            Staubli.Robotics.Soap.Proxies.ServerV1.getApplicationDatasResponse retVal = ((Staubli.Robotics.Soap.Proxies.ServerV1.CS8ServerV1PortType)(this)).getApplicationDatas(inValue);
            return retVal.data;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Staubli.Robotics.Soap.Proxies.ServerV1.getRecordsResponse Staubli.Robotics.Soap.Proxies.ServerV1.CS8ServerV1PortType.getRecords(Staubli.Robotics.Soap.Proxies.ServerV1.getRecordsRequest request)
        {
            return base.Channel.getRecords(request);
        }
        
        public string[] getRecords(int sessionId)
        {
            Staubli.Robotics.Soap.Proxies.ServerV1.getRecordsRequest inValue = new Staubli.Robotics.Soap.Proxies.ServerV1.getRecordsRequest();
            inValue.sessionId = sessionId;
            Staubli.Robotics.Soap.Proxies.ServerV1.getRecordsResponse retVal = ((Staubli.Robotics.Soap.Proxies.ServerV1.CS8ServerV1PortType)(this)).getRecords(inValue);
            return retVal.records;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Staubli.Robotics.Soap.Proxies.ServerV1.getRecordResponse Staubli.Robotics.Soap.Proxies.ServerV1.CS8ServerV1PortType.getRecord(Staubli.Robotics.Soap.Proxies.ServerV1.getRecordRequest request)
        {
            return base.Channel.getRecord(request);
        }
        
        public byte[] getRecord(int sessionId, string name)
        {
            Staubli.Robotics.Soap.Proxies.ServerV1.getRecordRequest inValue = new Staubli.Robotics.Soap.Proxies.ServerV1.getRecordRequest();
            inValue.sessionId = sessionId;
            inValue.name = name;
            Staubli.Robotics.Soap.Proxies.ServerV1.getRecordResponse retVal = ((Staubli.Robotics.Soap.Proxies.ServerV1.CS8ServerV1PortType)(this)).getRecord(inValue);
            return retVal.data;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Staubli.Robotics.Soap.Proxies.ServerV1.getJointRangeResponse Staubli.Robotics.Soap.Proxies.ServerV1.CS8ServerV1PortType.getJointRange(Staubli.Robotics.Soap.Proxies.ServerV1.getJointRangeRequest request)
        {
            return base.Channel.getJointRange(request);
        }
        
        public Staubli.Robotics.Soap.Proxies.ServerV1.JointRange getJointRange(int sessionId, int robot)
        {
            Staubli.Robotics.Soap.Proxies.ServerV1.getJointRangeRequest inValue = new Staubli.Robotics.Soap.Proxies.ServerV1.getJointRangeRequest();
            inValue.sessionId = sessionId;
            inValue.robot = robot;
            Staubli.Robotics.Soap.Proxies.ServerV1.getJointRangeResponse retVal = ((Staubli.Robotics.Soap.Proxies.ServerV1.CS8ServerV1PortType)(this)).getJointRange(inValue);
            return retVal.range;
        }
    }
}