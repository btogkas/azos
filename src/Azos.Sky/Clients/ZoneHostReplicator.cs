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
// This implementation needs @Azos.@Sky.@Contracts.@IZoneHostReplicatorClient, so
// it can be used with ServiceClientHub class

  ///<summary>
  /// Client for glued contract Azos.Sky.Contracts.IZoneHostReplicator server.
  /// Each contract method has synchronous and asynchronous versions, the later denoted by 'Async_' prefix.
  /// May inject client-level inspectors here like so:
  ///   client.MsgInspectors.Register( new YOUR_CLIENT_INSPECTOR_TYPE());
  ///</summary>
  public class ZoneHostReplicator : ClientEndPoint, @Azos.@Sky.@Contracts.@IZoneHostReplicatorClient
  {

  #region Static Members

     private static TypeSpec s_ts_CONTRACT;
     private static MethodSpec @s_ms_PostDynamicHostInfo_0;
     private static MethodSpec @s_ms_GetDynamicHostInfo_1;
     private static MethodSpec @s_ms_PostHostInfo_2;

     //static .ctor
     static ZoneHostReplicator()
     {
         var t = typeof(@Azos.@Sky.@Contracts.@IZoneHostReplicator);
         s_ts_CONTRACT = new TypeSpec(t);
         @s_ms_PostDynamicHostInfo_0 = new MethodSpec(t.GetMethod("PostDynamicHostInfo", new Type[]{ typeof(@Azos.@Sky.@Contracts.@DynamicHostID), typeof(@System.@DateTime), typeof(@System.@String), typeof(@System.@Int32) }));
         @s_ms_GetDynamicHostInfo_1 = new MethodSpec(t.GetMethod("GetDynamicHostInfo", new Type[]{ typeof(@Azos.@Sky.@Contracts.@DynamicHostID) }));
         @s_ms_PostHostInfo_2 = new MethodSpec(t.GetMethod("PostHostInfo", new Type[]{ typeof(@Azos.@Sky.@Contracts.@HostInfo), typeof(@System.@Nullable<@Azos.@Sky.@Contracts.@DynamicHostID>) }));
     }
  #endregion

  #region .ctor
     public ZoneHostReplicator(IGlue glue, string node, Binding binding = null) : base(glue, node, binding) { ctor(); }
     public ZoneHostReplicator(IGlue glue, Node node, Binding binding = null) : base(glue, node, binding) { ctor(); }

     //common instance .ctor body
     private void ctor()
     {

     }

  #endregion

     public override Type Contract
     {
       get { return typeof(@Azos.@Sky.@Contracts.@IZoneHostReplicator); }
     }



  #region Contract Methods

         ///<summary>
         /// Synchronous invoker for  'Azos.Sky.Contracts.IZoneHostReplicator.PostDynamicHostInfo'.
         /// This is a one-way call per contract specification, meaning - the server sends no acknowledgement of this call receipt and
         /// there is no result that server could return back to the caller.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         ///</summary>
         public void @PostDynamicHostInfo(@Azos.@Sky.@Contracts.@DynamicHostID  @id, @System.@DateTime  @stamp, @System.@String  @owner, @System.@Int32  @votes)
         {
            var call = Async_PostDynamicHostInfo(@id, @stamp, @owner, @votes);
            if (call.CallStatus != CallStatus.Dispatched)
                throw new ClientCallException(call.CallStatus, "Call failed: 'ZoneHostReplicator.PostDynamicHostInfo'");
         }

         ///<summary>
         /// Asynchronous invoker for  'Azos.Sky.Contracts.IZoneHostReplicator.PostDynamicHostInfo'.
         /// This is a one-way call per contract specification, meaning - the server sends no acknowledgement of this call receipt and
         /// there is no result that server could return back to the caller.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg.
         ///</summary>
         public CallSlot Async_PostDynamicHostInfo(@Azos.@Sky.@Contracts.@DynamicHostID  @id, @System.@DateTime  @stamp, @System.@String  @owner, @System.@Int32  @votes)
         {
            var request = new @Azos.@Sky.@Contracts.@RequestMsg_IZoneHostReplicator_PostDynamicHostInfo(s_ts_CONTRACT, @s_ms_PostDynamicHostInfo_0, true, RemoteInstance)
            {
               MethodArg_0_id = @id,
               MethodArg_1_stamp = @stamp,
               MethodArg_2_owner = @owner,
               MethodArg_3_votes = @votes,
            };
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Azos.Sky.Contracts.IZoneHostReplicator.GetDynamicHostInfo'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@Azos.@Sky.@Contracts.@DynamicHostInfo' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @Azos.@Sky.@Contracts.@DynamicHostInfo @GetDynamicHostInfo(@Azos.@Sky.@Contracts.@DynamicHostID  @hid)
         {
            var call = Async_GetDynamicHostInfo(@hid);
            return call.GetValue<@Azos.@Sky.@Contracts.@DynamicHostInfo>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Azos.Sky.Contracts.IZoneHostReplicator.GetDynamicHostInfo'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_GetDynamicHostInfo(@Azos.@Sky.@Contracts.@DynamicHostID  @hid)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_GetDynamicHostInfo_1, false, RemoteInstance, new object[]{@hid});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Azos.Sky.Contracts.IZoneHostReplicator.PostHostInfo'.
         /// This is a one-way call per contract specification, meaning - the server sends no acknowledgement of this call receipt and
         /// there is no result that server could return back to the caller.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         ///</summary>
         public void @PostHostInfo(@Azos.@Sky.@Contracts.@HostInfo  @host, @System.@Nullable<@Azos.@Sky.@Contracts.@DynamicHostID>  @hid)
         {
            var call = Async_PostHostInfo(@host, @hid);
            if (call.CallStatus != CallStatus.Dispatched)
                throw new ClientCallException(call.CallStatus, "Call failed: 'ZoneHostReplicator.PostHostInfo'");
         }

         ///<summary>
         /// Asynchronous invoker for  'Azos.Sky.Contracts.IZoneHostReplicator.PostHostInfo'.
         /// This is a one-way call per contract specification, meaning - the server sends no acknowledgement of this call receipt and
         /// there is no result that server could return back to the caller.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg.
         ///</summary>
         public CallSlot Async_PostHostInfo(@Azos.@Sky.@Contracts.@HostInfo  @host, @System.@Nullable<@Azos.@Sky.@Contracts.@DynamicHostID>  @hid)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_PostHostInfo_2, true, RemoteInstance, new object[]{@host, @hid});
            return DispatchCall(request);
         }


  #endregion

  }//class
}//namespace
