﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.586
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SponsorAnAFSer.GlobalLinkWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://afsglobal.org/", ConfigurationName="GlobalLinkWS.WebserviceFundAFSerSoap")]
    public interface WebserviceFundAFSerSoap {
        
        // CODEGEN: Generating message contract since element name userID from namespace http://afsglobal.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://afsglobal.org/AFSWidgetGetProgramDetails", ReplyAction="*")]
        SponsorAnAFSer.GlobalLinkWS.AFSWidgetGetProgramDetailsResponse AFSWidgetGetProgramDetails(SponsorAnAFSer.GlobalLinkWS.AFSWidgetGetProgramDetailsRequest request);
        
        // CODEGEN: Generating message contract since element name userID from namespace http://afsglobal.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://afsglobal.org/AFSWidgetSetCode", ReplyAction="*")]
        SponsorAnAFSer.GlobalLinkWS.AFSWidgetSetCodeResponse AFSWidgetSetCode(SponsorAnAFSer.GlobalLinkWS.AFSWidgetSetCodeRequest request);
        
        // CODEGEN: Generating message contract since element name userID from namespace http://afsglobal.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://afsglobal.org/AFSWidgetGLAuthentication", ReplyAction="*")]
        SponsorAnAFSer.GlobalLinkWS.AFSWidgetGLAuthenticationResponse AFSWidgetGLAuthentication(SponsorAnAFSer.GlobalLinkWS.AFSWidgetGLAuthenticationRequest request);
        
        // CODEGEN: Generating message contract since element name userID from namespace http://afsglobal.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://afsglobal.org/AFSWidgetPaymentDetails", ReplyAction="*")]
        SponsorAnAFSer.GlobalLinkWS.AFSWidgetPaymentDetailsResponse AFSWidgetPaymentDetails(SponsorAnAFSer.GlobalLinkWS.AFSWidgetPaymentDetailsRequest request);
        
        // CODEGEN: Generating message contract since element name userID from namespace http://afsglobal.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://afsglobal.org/AFSWidgetStatusUpdate", ReplyAction="*")]
        SponsorAnAFSer.GlobalLinkWS.AFSWidgetStatusUpdateResponse AFSWidgetStatusUpdate(SponsorAnAFSer.GlobalLinkWS.AFSWidgetStatusUpdateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AFSWidgetGetProgramDetailsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AFSWidgetGetProgramDetails", Namespace="http://afsglobal.org/", Order=0)]
        public SponsorAnAFSer.GlobalLinkWS.AFSWidgetGetProgramDetailsRequestBody Body;
        
        public AFSWidgetGetProgramDetailsRequest() {
        }
        
        public AFSWidgetGetProgramDetailsRequest(SponsorAnAFSer.GlobalLinkWS.AFSWidgetGetProgramDetailsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://afsglobal.org/")]
    public partial class AFSWidgetGetProgramDetailsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string passWord;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string serviceID;
        
        public AFSWidgetGetProgramDetailsRequestBody() {
        }
        
        public AFSWidgetGetProgramDetailsRequestBody(string userID, string passWord, string serviceID) {
            this.userID = userID;
            this.passWord = passWord;
            this.serviceID = serviceID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AFSWidgetGetProgramDetailsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AFSWidgetGetProgramDetailsResponse", Namespace="http://afsglobal.org/", Order=0)]
        public SponsorAnAFSer.GlobalLinkWS.AFSWidgetGetProgramDetailsResponseBody Body;
        
        public AFSWidgetGetProgramDetailsResponse() {
        }
        
        public AFSWidgetGetProgramDetailsResponse(SponsorAnAFSer.GlobalLinkWS.AFSWidgetGetProgramDetailsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://afsglobal.org/")]
    public partial class AFSWidgetGetProgramDetailsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement AFSWidgetGetProgramDetailsResult;
        
        public AFSWidgetGetProgramDetailsResponseBody() {
        }
        
        public AFSWidgetGetProgramDetailsResponseBody(System.Xml.Linq.XElement AFSWidgetGetProgramDetailsResult) {
            this.AFSWidgetGetProgramDetailsResult = AFSWidgetGetProgramDetailsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AFSWidgetSetCodeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AFSWidgetSetCode", Namespace="http://afsglobal.org/", Order=0)]
        public SponsorAnAFSer.GlobalLinkWS.AFSWidgetSetCodeRequestBody Body;
        
        public AFSWidgetSetCodeRequest() {
        }
        
        public AFSWidgetSetCodeRequest(SponsorAnAFSer.GlobalLinkWS.AFSWidgetSetCodeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://afsglobal.org/")]
    public partial class AFSWidgetSetCodeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string passWord;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string serviceID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string widgetID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string widgetCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string widgetEndDate;
        
        public AFSWidgetSetCodeRequestBody() {
        }
        
        public AFSWidgetSetCodeRequestBody(string userID, string passWord, string serviceID, string widgetID, string widgetCode, string widgetEndDate) {
            this.userID = userID;
            this.passWord = passWord;
            this.serviceID = serviceID;
            this.widgetID = widgetID;
            this.widgetCode = widgetCode;
            this.widgetEndDate = widgetEndDate;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AFSWidgetSetCodeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AFSWidgetSetCodeResponse", Namespace="http://afsglobal.org/", Order=0)]
        public SponsorAnAFSer.GlobalLinkWS.AFSWidgetSetCodeResponseBody Body;
        
        public AFSWidgetSetCodeResponse() {
        }
        
        public AFSWidgetSetCodeResponse(SponsorAnAFSer.GlobalLinkWS.AFSWidgetSetCodeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://afsglobal.org/")]
    public partial class AFSWidgetSetCodeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement AFSWidgetSetCodeResult;
        
        public AFSWidgetSetCodeResponseBody() {
        }
        
        public AFSWidgetSetCodeResponseBody(System.Xml.Linq.XElement AFSWidgetSetCodeResult) {
            this.AFSWidgetSetCodeResult = AFSWidgetSetCodeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AFSWidgetGLAuthenticationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AFSWidgetGLAuthentication", Namespace="http://afsglobal.org/", Order=0)]
        public SponsorAnAFSer.GlobalLinkWS.AFSWidgetGLAuthenticationRequestBody Body;
        
        public AFSWidgetGLAuthenticationRequest() {
        }
        
        public AFSWidgetGLAuthenticationRequest(SponsorAnAFSer.GlobalLinkWS.AFSWidgetGLAuthenticationRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://afsglobal.org/")]
    public partial class AFSWidgetGLAuthenticationRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string passWord;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string userID_GL;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string passWord_GL;
        
        public AFSWidgetGLAuthenticationRequestBody() {
        }
        
        public AFSWidgetGLAuthenticationRequestBody(string userID, string passWord, string userID_GL, string passWord_GL) {
            this.userID = userID;
            this.passWord = passWord;
            this.userID_GL = userID_GL;
            this.passWord_GL = passWord_GL;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AFSWidgetGLAuthenticationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AFSWidgetGLAuthenticationResponse", Namespace="http://afsglobal.org/", Order=0)]
        public SponsorAnAFSer.GlobalLinkWS.AFSWidgetGLAuthenticationResponseBody Body;
        
        public AFSWidgetGLAuthenticationResponse() {
        }
        
        public AFSWidgetGLAuthenticationResponse(SponsorAnAFSer.GlobalLinkWS.AFSWidgetGLAuthenticationResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://afsglobal.org/")]
    public partial class AFSWidgetGLAuthenticationResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement AFSWidgetGLAuthenticationResult;
        
        public AFSWidgetGLAuthenticationResponseBody() {
        }
        
        public AFSWidgetGLAuthenticationResponseBody(System.Xml.Linq.XElement AFSWidgetGLAuthenticationResult) {
            this.AFSWidgetGLAuthenticationResult = AFSWidgetGLAuthenticationResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AFSWidgetPaymentDetailsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AFSWidgetPaymentDetails", Namespace="http://afsglobal.org/", Order=0)]
        public SponsorAnAFSer.GlobalLinkWS.AFSWidgetPaymentDetailsRequestBody Body;
        
        public AFSWidgetPaymentDetailsRequest() {
        }
        
        public AFSWidgetPaymentDetailsRequest(SponsorAnAFSer.GlobalLinkWS.AFSWidgetPaymentDetailsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://afsglobal.org/")]
    public partial class AFSWidgetPaymentDetailsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string passWord;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string serviceID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string widgetID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string transactionID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string paymentID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string payerFirstName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string payerLastname;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string payerAddr;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string payerCity;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string payerState;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public string payerZip;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=12)]
        public string payerEmail;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=13)]
        public string aMount;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=14)]
        public string msgToPax;
        
        public AFSWidgetPaymentDetailsRequestBody() {
        }
        
        public AFSWidgetPaymentDetailsRequestBody(string userID, string passWord, string serviceID, string widgetID, string transactionID, string paymentID, string payerFirstName, string payerLastname, string payerAddr, string payerCity, string payerState, string payerZip, string payerEmail, string aMount, string msgToPax) {
            this.userID = userID;
            this.passWord = passWord;
            this.serviceID = serviceID;
            this.widgetID = widgetID;
            this.transactionID = transactionID;
            this.paymentID = paymentID;
            this.payerFirstName = payerFirstName;
            this.payerLastname = payerLastname;
            this.payerAddr = payerAddr;
            this.payerCity = payerCity;
            this.payerState = payerState;
            this.payerZip = payerZip;
            this.payerEmail = payerEmail;
            this.aMount = aMount;
            this.msgToPax = msgToPax;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AFSWidgetPaymentDetailsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AFSWidgetPaymentDetailsResponse", Namespace="http://afsglobal.org/", Order=0)]
        public SponsorAnAFSer.GlobalLinkWS.AFSWidgetPaymentDetailsResponseBody Body;
        
        public AFSWidgetPaymentDetailsResponse() {
        }
        
        public AFSWidgetPaymentDetailsResponse(SponsorAnAFSer.GlobalLinkWS.AFSWidgetPaymentDetailsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://afsglobal.org/")]
    public partial class AFSWidgetPaymentDetailsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement AFSWidgetPaymentDetailsResult;
        
        public AFSWidgetPaymentDetailsResponseBody() {
        }
        
        public AFSWidgetPaymentDetailsResponseBody(System.Xml.Linq.XElement AFSWidgetPaymentDetailsResult) {
            this.AFSWidgetPaymentDetailsResult = AFSWidgetPaymentDetailsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AFSWidgetStatusUpdateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AFSWidgetStatusUpdate", Namespace="http://afsglobal.org/", Order=0)]
        public SponsorAnAFSer.GlobalLinkWS.AFSWidgetStatusUpdateRequestBody Body;
        
        public AFSWidgetStatusUpdateRequest() {
        }
        
        public AFSWidgetStatusUpdateRequest(SponsorAnAFSer.GlobalLinkWS.AFSWidgetStatusUpdateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://afsglobal.org/")]
    public partial class AFSWidgetStatusUpdateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string passWord;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string serviceID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string widgetID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string status;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string modifiedDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string comment;
        
        public AFSWidgetStatusUpdateRequestBody() {
        }
        
        public AFSWidgetStatusUpdateRequestBody(string userID, string passWord, string serviceID, string widgetID, string status, string modifiedDate, string comment) {
            this.userID = userID;
            this.passWord = passWord;
            this.serviceID = serviceID;
            this.widgetID = widgetID;
            this.status = status;
            this.modifiedDate = modifiedDate;
            this.comment = comment;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AFSWidgetStatusUpdateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AFSWidgetStatusUpdateResponse", Namespace="http://afsglobal.org/", Order=0)]
        public SponsorAnAFSer.GlobalLinkWS.AFSWidgetStatusUpdateResponseBody Body;
        
        public AFSWidgetStatusUpdateResponse() {
        }
        
        public AFSWidgetStatusUpdateResponse(SponsorAnAFSer.GlobalLinkWS.AFSWidgetStatusUpdateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://afsglobal.org/")]
    public partial class AFSWidgetStatusUpdateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement AFSWidgetStatusUpdateResult;
        
        public AFSWidgetStatusUpdateResponseBody() {
        }
        
        public AFSWidgetStatusUpdateResponseBody(System.Xml.Linq.XElement AFSWidgetStatusUpdateResult) {
            this.AFSWidgetStatusUpdateResult = AFSWidgetStatusUpdateResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebserviceFundAFSerSoapChannel : SponsorAnAFSer.GlobalLinkWS.WebserviceFundAFSerSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebserviceFundAFSerSoapClient : System.ServiceModel.ClientBase<SponsorAnAFSer.GlobalLinkWS.WebserviceFundAFSerSoap>, SponsorAnAFSer.GlobalLinkWS.WebserviceFundAFSerSoap {
        
        public WebserviceFundAFSerSoapClient() {
        }
        
        public WebserviceFundAFSerSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebserviceFundAFSerSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebserviceFundAFSerSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebserviceFundAFSerSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SponsorAnAFSer.GlobalLinkWS.AFSWidgetGetProgramDetailsResponse SponsorAnAFSer.GlobalLinkWS.WebserviceFundAFSerSoap.AFSWidgetGetProgramDetails(SponsorAnAFSer.GlobalLinkWS.AFSWidgetGetProgramDetailsRequest request) {
            return base.Channel.AFSWidgetGetProgramDetails(request);
        }
        
        public System.Xml.Linq.XElement AFSWidgetGetProgramDetails(string userID, string passWord, string serviceID) {
            SponsorAnAFSer.GlobalLinkWS.AFSWidgetGetProgramDetailsRequest inValue = new SponsorAnAFSer.GlobalLinkWS.AFSWidgetGetProgramDetailsRequest();
            inValue.Body = new SponsorAnAFSer.GlobalLinkWS.AFSWidgetGetProgramDetailsRequestBody();
            inValue.Body.userID = userID;
            inValue.Body.passWord = passWord;
            inValue.Body.serviceID = serviceID;
            SponsorAnAFSer.GlobalLinkWS.AFSWidgetGetProgramDetailsResponse retVal = ((SponsorAnAFSer.GlobalLinkWS.WebserviceFundAFSerSoap)(this)).AFSWidgetGetProgramDetails(inValue);
            return retVal.Body.AFSWidgetGetProgramDetailsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SponsorAnAFSer.GlobalLinkWS.AFSWidgetSetCodeResponse SponsorAnAFSer.GlobalLinkWS.WebserviceFundAFSerSoap.AFSWidgetSetCode(SponsorAnAFSer.GlobalLinkWS.AFSWidgetSetCodeRequest request) {
            return base.Channel.AFSWidgetSetCode(request);
        }
        
        public System.Xml.Linq.XElement AFSWidgetSetCode(string userID, string passWord, string serviceID, string widgetID, string widgetCode, string widgetEndDate) {
            SponsorAnAFSer.GlobalLinkWS.AFSWidgetSetCodeRequest inValue = new SponsorAnAFSer.GlobalLinkWS.AFSWidgetSetCodeRequest();
            inValue.Body = new SponsorAnAFSer.GlobalLinkWS.AFSWidgetSetCodeRequestBody();
            inValue.Body.userID = userID;
            inValue.Body.passWord = passWord;
            inValue.Body.serviceID = serviceID;
            inValue.Body.widgetID = widgetID;
            inValue.Body.widgetCode = widgetCode;
            inValue.Body.widgetEndDate = widgetEndDate;
            SponsorAnAFSer.GlobalLinkWS.AFSWidgetSetCodeResponse retVal = ((SponsorAnAFSer.GlobalLinkWS.WebserviceFundAFSerSoap)(this)).AFSWidgetSetCode(inValue);
            return retVal.Body.AFSWidgetSetCodeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SponsorAnAFSer.GlobalLinkWS.AFSWidgetGLAuthenticationResponse SponsorAnAFSer.GlobalLinkWS.WebserviceFundAFSerSoap.AFSWidgetGLAuthentication(SponsorAnAFSer.GlobalLinkWS.AFSWidgetGLAuthenticationRequest request) {
            return base.Channel.AFSWidgetGLAuthentication(request);
        }
        
        public System.Xml.Linq.XElement AFSWidgetGLAuthentication(string userID, string passWord, string userID_GL, string passWord_GL) {
            SponsorAnAFSer.GlobalLinkWS.AFSWidgetGLAuthenticationRequest inValue = new SponsorAnAFSer.GlobalLinkWS.AFSWidgetGLAuthenticationRequest();
            inValue.Body = new SponsorAnAFSer.GlobalLinkWS.AFSWidgetGLAuthenticationRequestBody();
            inValue.Body.userID = userID;
            inValue.Body.passWord = passWord;
            inValue.Body.userID_GL = userID_GL;
            inValue.Body.passWord_GL = passWord_GL;
            SponsorAnAFSer.GlobalLinkWS.AFSWidgetGLAuthenticationResponse retVal = ((SponsorAnAFSer.GlobalLinkWS.WebserviceFundAFSerSoap)(this)).AFSWidgetGLAuthentication(inValue);
            return retVal.Body.AFSWidgetGLAuthenticationResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SponsorAnAFSer.GlobalLinkWS.AFSWidgetPaymentDetailsResponse SponsorAnAFSer.GlobalLinkWS.WebserviceFundAFSerSoap.AFSWidgetPaymentDetails(SponsorAnAFSer.GlobalLinkWS.AFSWidgetPaymentDetailsRequest request) {
            return base.Channel.AFSWidgetPaymentDetails(request);
        }
        
        public System.Xml.Linq.XElement AFSWidgetPaymentDetails(string userID, string passWord, string serviceID, string widgetID, string transactionID, string paymentID, string payerFirstName, string payerLastname, string payerAddr, string payerCity, string payerState, string payerZip, string payerEmail, string aMount, string msgToPax) {
            SponsorAnAFSer.GlobalLinkWS.AFSWidgetPaymentDetailsRequest inValue = new SponsorAnAFSer.GlobalLinkWS.AFSWidgetPaymentDetailsRequest();
            inValue.Body = new SponsorAnAFSer.GlobalLinkWS.AFSWidgetPaymentDetailsRequestBody();
            inValue.Body.userID = userID;
            inValue.Body.passWord = passWord;
            inValue.Body.serviceID = serviceID;
            inValue.Body.widgetID = widgetID;
            inValue.Body.transactionID = transactionID;
            inValue.Body.paymentID = paymentID;
            inValue.Body.payerFirstName = payerFirstName;
            inValue.Body.payerLastname = payerLastname;
            inValue.Body.payerAddr = payerAddr;
            inValue.Body.payerCity = payerCity;
            inValue.Body.payerState = payerState;
            inValue.Body.payerZip = payerZip;
            inValue.Body.payerEmail = payerEmail;
            inValue.Body.aMount = aMount;
            inValue.Body.msgToPax = msgToPax;
            SponsorAnAFSer.GlobalLinkWS.AFSWidgetPaymentDetailsResponse retVal = ((SponsorAnAFSer.GlobalLinkWS.WebserviceFundAFSerSoap)(this)).AFSWidgetPaymentDetails(inValue);
            return retVal.Body.AFSWidgetPaymentDetailsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SponsorAnAFSer.GlobalLinkWS.AFSWidgetStatusUpdateResponse SponsorAnAFSer.GlobalLinkWS.WebserviceFundAFSerSoap.AFSWidgetStatusUpdate(SponsorAnAFSer.GlobalLinkWS.AFSWidgetStatusUpdateRequest request) {
            return base.Channel.AFSWidgetStatusUpdate(request);
        }
        
        public System.Xml.Linq.XElement AFSWidgetStatusUpdate(string userID, string passWord, string serviceID, string widgetID, string status, string modifiedDate, string comment) {
            SponsorAnAFSer.GlobalLinkWS.AFSWidgetStatusUpdateRequest inValue = new SponsorAnAFSer.GlobalLinkWS.AFSWidgetStatusUpdateRequest();
            inValue.Body = new SponsorAnAFSer.GlobalLinkWS.AFSWidgetStatusUpdateRequestBody();
            inValue.Body.userID = userID;
            inValue.Body.passWord = passWord;
            inValue.Body.serviceID = serviceID;
            inValue.Body.widgetID = widgetID;
            inValue.Body.status = status;
            inValue.Body.modifiedDate = modifiedDate;
            inValue.Body.comment = comment;
            SponsorAnAFSer.GlobalLinkWS.AFSWidgetStatusUpdateResponse retVal = ((SponsorAnAFSer.GlobalLinkWS.WebserviceFundAFSerSoap)(this)).AFSWidgetStatusUpdate(inValue);
            return retVal.Body.AFSWidgetStatusUpdateResult;
        }
    }
}
