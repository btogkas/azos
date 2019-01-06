/*<FILE_LICENSE>
 * Azos (A to Z Application Operating System) Framework
 * The A to Z Foundation (a.k.a. Azist) licenses this file to you under the MIT license.
 * See the LICENSE file in the project root for more information.
</FILE_LICENSE>*/
//Generated by Azos.Sky.Clients.Tools.SkyGluecCompiler

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Azos.Glue;
using Azos.Glue.Protocol;


namespace Azos.Sky.Clients
{
// This implementation needs @Azos.@Sky.@Contracts.@IWebMessageSystemClient, so
// it can be used with ServiceClientHub class

  ///<summary>
  /// Client for glued contract Azos.Sky.Contracts.IWebMessageSystem server.
  /// Each contract method has synchronous and asynchronous versions, the later denoted by 'Async_' prefix.
  /// May inject client-level inspectors here like so:
  ///   client.MsgInspectors.Register( new YOUR_CLIENT_INSPECTOR_TYPE());
  ///</summary>
  public class WebMessageSystem : ClientEndPoint, @Azos.@Sky.@Contracts.@IWebMessageSystemClient
  {

  #region Static Members

     private static TypeSpec s_ts_CONTRACT;
     private static MethodSpec @s_ms_SendMessage_0;
     private static MethodSpec @s_ms_GetMailboxInfo_1;
     private static MethodSpec @s_ms_UpdateMailboxMessageStatus_2;
     private static MethodSpec @s_ms_UpdateMailboxMessagesStatus_3;
     private static MethodSpec @s_ms_UpdateMailboxMessagePublication_4;
     private static MethodSpec @s_ms_GetMailboxMessageHeaders_5;
     private static MethodSpec @s_ms_GetMailboxMessageCount_6;
     private static MethodSpec @s_ms_FetchMailboxMessage_7;
     private static MethodSpec @s_ms_FetchMailboxMessageAttachment_8;

     //static .ctor
     static WebMessageSystem()
     {
         var t = typeof(@Azos.@Sky.@Contracts.@IWebMessageSystem);
         s_ts_CONTRACT = new TypeSpec(t);
         @s_ms_SendMessage_0 = new MethodSpec(t.GetMethod("SendMessage", new Type[]{ typeof(@Azos.@Sky.@WebMessaging.@SkyWebMessage) }));
         @s_ms_GetMailboxInfo_1 = new MethodSpec(t.GetMethod("GetMailboxInfo", new Type[]{ typeof(@Azos.@Sky.@WebMessaging.@MailboxID) }));
         @s_ms_UpdateMailboxMessageStatus_2 = new MethodSpec(t.GetMethod("UpdateMailboxMessageStatus", new Type[]{ typeof(@Azos.@Sky.@WebMessaging.@MailboxMsgID), typeof(@Azos.@Sky.@WebMessaging.@MsgStatus), typeof(@System.@String), typeof(@System.@String) }));
         @s_ms_UpdateMailboxMessagesStatus_3 = new MethodSpec(t.GetMethod("UpdateMailboxMessagesStatus", new Type[]{ typeof(@System.@Collections.@Generic.@IEnumerable<@Azos.@Sky.@WebMessaging.@MailboxMsgID>), typeof(@Azos.@Sky.@WebMessaging.@MsgStatus), typeof(@System.@String), typeof(@System.@String) }));
         @s_ms_UpdateMailboxMessagePublication_4 = new MethodSpec(t.GetMethod("UpdateMailboxMessagePublication", new Type[]{ typeof(@Azos.@Sky.@WebMessaging.@MailboxMsgID), typeof(@Azos.@Sky.@WebMessaging.@MsgPubStatus), typeof(@System.@String), typeof(@System.@String) }));
         @s_ms_GetMailboxMessageHeaders_5 = new MethodSpec(t.GetMethod("GetMailboxMessageHeaders", new Type[]{ typeof(@Azos.@Sky.@WebMessaging.@MailboxID), typeof(@System.@String) }));
         @s_ms_GetMailboxMessageCount_6 = new MethodSpec(t.GetMethod("GetMailboxMessageCount", new Type[]{ typeof(@Azos.@Sky.@WebMessaging.@MailboxID), typeof(@System.@String) }));
         @s_ms_FetchMailboxMessage_7 = new MethodSpec(t.GetMethod("FetchMailboxMessage", new Type[]{ typeof(@Azos.@Sky.@WebMessaging.@MailboxMsgID) }));
         @s_ms_FetchMailboxMessageAttachment_8 = new MethodSpec(t.GetMethod("FetchMailboxMessageAttachment", new Type[]{ typeof(@Azos.@Sky.@WebMessaging.@MailboxMsgID), typeof(@System.@Int32) }));
     }
  #endregion

  #region .ctor
     public WebMessageSystem(IGlue glue, string node, Binding binding = null) : base(glue, node, binding) { ctor(); }
     public WebMessageSystem(IGlue glue, Node node, Binding binding = null) : base(glue, node, binding) { ctor(); }

     //common instance .ctor body
     private void ctor()
     {

     }

  #endregion

     public override Type Contract
     {
       get { return typeof(@Azos.@Sky.@Contracts.@IWebMessageSystem); }
     }



  #region Contract Methods

         ///<summary>
         /// Synchronous invoker for  'Azos.Sky.Contracts.IWebMessageSystem.SendMessage'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@Azos.@Sky.@Contracts.@MsgSendInfo[]' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @Azos.@Sky.@Contracts.@MsgSendInfo[] @SendMessage(@Azos.@Sky.@WebMessaging.@SkyWebMessage  @msg)
         {
            var call = Async_SendMessage(@msg);
            return call.GetValue<@Azos.@Sky.@Contracts.@MsgSendInfo[]>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Azos.Sky.Contracts.IWebMessageSystem.SendMessage'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_SendMessage(@Azos.@Sky.@WebMessaging.@SkyWebMessage  @msg)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_SendMessage_0, false, RemoteInstance, new object[]{@msg});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Azos.Sky.Contracts.IWebMessageSystem.GetMailboxInfo'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@Azos.@Sky.@WebMessaging.@MailboxInfo' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @Azos.@Sky.@WebMessaging.@MailboxInfo @GetMailboxInfo(@Azos.@Sky.@WebMessaging.@MailboxID  @xid)
         {
            var call = Async_GetMailboxInfo(@xid);
            return call.GetValue<@Azos.@Sky.@WebMessaging.@MailboxInfo>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Azos.Sky.Contracts.IWebMessageSystem.GetMailboxInfo'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_GetMailboxInfo(@Azos.@Sky.@WebMessaging.@MailboxID  @xid)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_GetMailboxInfo_1, false, RemoteInstance, new object[]{@xid});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Azos.Sky.Contracts.IWebMessageSystem.UpdateMailboxMessageStatus'.
         /// This is a one-way call per contract specification, meaning - the server sends no acknowledgement of this call receipt and
         /// there is no result that server could return back to the caller.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         ///</summary>
         public void @UpdateMailboxMessageStatus(@Azos.@Sky.@WebMessaging.@MailboxMsgID  @mid, @Azos.@Sky.@WebMessaging.@MsgStatus  @status, @System.@String  @folders, @System.@String  @adornments)
         {
            var call = Async_UpdateMailboxMessageStatus(@mid, @status, @folders, @adornments);
            if (call.CallStatus != CallStatus.Dispatched)
                throw new ClientCallException(call.CallStatus, "Call failed: 'WebMessageSystem.UpdateMailboxMessageStatus'");
         }

         ///<summary>
         /// Asynchronous invoker for  'Azos.Sky.Contracts.IWebMessageSystem.UpdateMailboxMessageStatus'.
         /// This is a one-way call per contract specification, meaning - the server sends no acknowledgement of this call receipt and
         /// there is no result that server could return back to the caller.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg.
         ///</summary>
         public CallSlot Async_UpdateMailboxMessageStatus(@Azos.@Sky.@WebMessaging.@MailboxMsgID  @mid, @Azos.@Sky.@WebMessaging.@MsgStatus  @status, @System.@String  @folders, @System.@String  @adornments)
         {
            var request = new @Azos.@Sky.@Contracts.@RequestMsg_IWebMessageSystem_UpdateMailboxMessageStatus(s_ts_CONTRACT, @s_ms_UpdateMailboxMessageStatus_2, true, RemoteInstance)
            {
               MethodArg_0_mid = @mid,
               MethodArg_1_status = @status,
               MethodArg_2_folders = @folders,
               MethodArg_3_adornments = @adornments,
            };
            return DispatchCall(request);
         }

    ///<summary>
         /// Synchronous invoker for  'Azos.Sky.Contracts.IWebMessageSystem.UpdateMailboxMessagesStatus'.
         /// This is a one-way call per contract specification, meaning - the server sends no acknowledgement of this call receipt and
         /// there is no result that server could return back to the caller.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         ///</summary>
         public void @UpdateMailboxMessagesStatus(@System.@Collections.@Generic.@IEnumerable<@Azos.@Sky.@WebMessaging.@MailboxMsgID>  @mids, @Azos.@Sky.@WebMessaging.@MsgStatus  @status, @System.@String  @folders, @System.@String  @adornments)
         {
            var call = Async_UpdateMailboxMessagesStatus(@mids, @status, @folders, @adornments);
            if (call.CallStatus != CallStatus.Dispatched)
                throw new ClientCallException(call.CallStatus, "Call failed: 'WebMessageSystem.UpdateMailboxMessagesStatus'");
         }

         ///<summary>
         /// Asynchronous invoker for  'Azos.Sky.Contracts.IWebMessageSystem.UpdateMailboxMessagesStatus'.
         /// This is a one-way call per contract specification, meaning - the server sends no acknowledgement of this call receipt and
         /// there is no result that server could return back to the caller.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg.
         ///</summary>
         public CallSlot Async_UpdateMailboxMessagesStatus(@System.@Collections.@Generic.@IEnumerable<@Azos.@Sky.@WebMessaging.@MailboxMsgID>  @mids, @Azos.@Sky.@WebMessaging.@MsgStatus  @status, @System.@String  @folders, @System.@String  @adornments)
         {
            var request = new @Azos.@Sky.@Contracts.@RequestMsg_IWebMessageSystem_UpdateMailboxMessagesStatus(s_ts_CONTRACT, @s_ms_UpdateMailboxMessagesStatus_3, true, RemoteInstance)
            {
               MethodArg_0_mids = @mids,
               MethodArg_1_status = @status,
               MethodArg_2_folders = @folders,
               MethodArg_3_adornments = @adornments,
            };
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Azos.Sky.Contracts.IWebMessageSystem.UpdateMailboxMessagePublication'.
         /// This is a one-way call per contract specification, meaning - the server sends no acknowledgement of this call receipt and
         /// there is no result that server could return back to the caller.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         ///</summary>
         public void @UpdateMailboxMessagePublication(@Azos.@Sky.@WebMessaging.@MailboxMsgID  @mid, @Azos.@Sky.@WebMessaging.@MsgPubStatus  @status, @System.@String  @oper, @System.@String  @description)
         {
            var call = Async_UpdateMailboxMessagePublication(@mid, @status, @oper, @description);
            if (call.CallStatus != CallStatus.Dispatched)
                throw new ClientCallException(call.CallStatus, "Call failed: 'WebMessageSystem.UpdateMailboxMessagePublication'");
         }

         ///<summary>
         /// Asynchronous invoker for  'Azos.Sky.Contracts.IWebMessageSystem.UpdateMailboxMessagePublication'.
         /// This is a one-way call per contract specification, meaning - the server sends no acknowledgement of this call receipt and
         /// there is no result that server could return back to the caller.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg.
         ///</summary>
         public CallSlot Async_UpdateMailboxMessagePublication(@Azos.@Sky.@WebMessaging.@MailboxMsgID  @mid, @Azos.@Sky.@WebMessaging.@MsgPubStatus  @status, @System.@String  @oper, @System.@String  @description)
         {
            var request = new @Azos.@Sky.@Contracts.@RequestMsg_IWebMessageSystem_UpdateMailboxMessagePublication(s_ts_CONTRACT, @s_ms_UpdateMailboxMessagePublication_4, true, RemoteInstance)
            {
               MethodArg_0_mid = @mid,
               MethodArg_1_status = @status,
               MethodArg_2_oper = @oper,
               MethodArg_3_description = @description,
            };
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Azos.Sky.Contracts.IWebMessageSystem.GetMailboxMessageHeaders'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@Azos.@Sky.@Contracts.@MessageHeaders' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @Azos.@Sky.@Contracts.@MessageHeaders @GetMailboxMessageHeaders(@Azos.@Sky.@WebMessaging.@MailboxID  @xid, @System.@String  @query)
         {
            var call = Async_GetMailboxMessageHeaders(@xid, @query);
            return call.GetValue<@Azos.@Sky.@Contracts.@MessageHeaders>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Azos.Sky.Contracts.IWebMessageSystem.GetMailboxMessageHeaders'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_GetMailboxMessageHeaders(@Azos.@Sky.@WebMessaging.@MailboxID  @xid, @System.@String  @query)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_GetMailboxMessageHeaders_5, false, RemoteInstance, new object[]{@xid, @query});
            return DispatchCall(request);
         }

          ///<summary>
         /// Synchronous invoker for  'Azos.Sky.Contracts.IWebMessageSystem.GetMailboxMessageCount'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@Azos.@Sky.@Contracts.@MessageHeaders' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public int @GetMailboxMessageCount(@Azos.@Sky.@WebMessaging.@MailboxID  @xid, @System.@String  @query)
         {
            var call = Async_GetMailboxMessageCount(@xid, @query);
            return call.GetValue<int>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Azos.Sky.Contracts.IWebMessageSystem.GetMailboxMessageCount'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_GetMailboxMessageCount(@Azos.@Sky.@WebMessaging.@MailboxID  @xid, @System.@String  @query)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_GetMailboxMessageCount_6, false, RemoteInstance, new object[]{@xid, @query});
            return DispatchCall(request);
         }


         ///<summary>
         /// Synchronous invoker for  'Azos.Sky.Contracts.IWebMessageSystem.FetchMailboxMessage'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@Azos.@Sky.@WebMessaging.@SkyWebMessage' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @Azos.@Sky.@WebMessaging.@SkyWebMessage @FetchMailboxMessage(@Azos.@Sky.@WebMessaging.@MailboxMsgID  @mid)
         {
            var call = Async_FetchMailboxMessage(@mid);
            return call.GetValue<@Azos.@Sky.@WebMessaging.@SkyWebMessage>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Azos.Sky.Contracts.IWebMessageSystem.FetchMailboxMessage'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_FetchMailboxMessage(@Azos.@Sky.@WebMessaging.@MailboxMsgID  @mid)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, s_ms_FetchMailboxMessage_7, false, RemoteInstance, new object[]{@mid});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Azos.Sky.Contracts.IWebMessageSystem.FetchMailboxMessageAttachment'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@Azos.@Web.@Messaging.@Message.@Attachment' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @Azos.@Web.@Messaging.@Message.@Attachment @FetchMailboxMessageAttachment(@Azos.@Sky.@WebMessaging.@MailboxMsgID  @mid, @System.@Int32  @attachmentIndex)
         {
            var call = Async_FetchMailboxMessageAttachment(@mid, @attachmentIndex);
            return call.GetValue<@Azos.@Web.@Messaging.@Message.@Attachment>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Azos.Sky.Contracts.IWebMessageSystem.FetchMailboxMessageAttachment'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_FetchMailboxMessageAttachment(@Azos.@Sky.@WebMessaging.@MailboxMsgID  @mid, @System.@Int32  @attachmentIndex)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, s_ms_FetchMailboxMessageAttachment_8, false, RemoteInstance, new object[]{@mid, @attachmentIndex});
            return DispatchCall(request);
         }


  #endregion

  }//class
}//namespace
