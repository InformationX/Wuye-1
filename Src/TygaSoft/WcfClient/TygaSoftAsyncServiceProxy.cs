﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="TygaSoft.Services.SysLogService", ConfigurationName="ISysLog")]
public interface ISysLog
{
    
    [System.ServiceModel.OperationContractAttribute(Action="TygaSoft.Services.SysLogService/ISysLog/InsertWeixinLog", ReplyAction="TygaSoft.Services.SysLogService/ISysLog/InsertWeixinLogResponse")]
    void InsertWeixinLog(string appName, string interfaceName, string Message);
    
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="TygaSoft.Services.SysLogService/ISysLog/InsertWeixinLog", ReplyAction="TygaSoft.Services.SysLogService/ISysLog/InsertWeixinLogResponse")]
    System.IAsyncResult BeginInsertWeixinLog(string appName, string interfaceName, string Message, System.AsyncCallback callback, object asyncState);
    
    void EndInsertWeixinLog(System.IAsyncResult result);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ISysLogChannel : ISysLog, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class SysLogClient : System.ServiceModel.ClientBase<ISysLog>, ISysLog
{
    
    public SysLogClient()
    {
    }
    
    public SysLogClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public SysLogClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public SysLogClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public SysLogClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public void InsertWeixinLog(string appName, string interfaceName, string Message)
    {
        base.Channel.InsertWeixinLog(appName, interfaceName, Message);
    }
    
    public System.IAsyncResult BeginInsertWeixinLog(string appName, string interfaceName, string Message, System.AsyncCallback callback, object asyncState)
    {
        return base.Channel.BeginInsertWeixinLog(appName, interfaceName, Message, callback, asyncState);
    }
    
    public void EndInsertWeixinLog(System.IAsyncResult result)
    {
        base.Channel.EndInsertWeixinLog(result);
    }
}
