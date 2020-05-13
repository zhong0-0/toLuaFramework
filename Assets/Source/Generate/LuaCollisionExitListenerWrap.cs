﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LuaCollisionExitListenerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaCollisionExitListener), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("OnEvent", get_OnEvent, set_OnEvent);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnEvent(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action<UnityEngine.Collision>)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnEvent(IntPtr L)
	{
		try
		{
			LuaCollisionExitListener obj = (LuaCollisionExitListener)ToLua.CheckObject(L, 1, typeof(LuaCollisionExitListener));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'LuaCollisionExitListener.OnEvent' can only appear on the left hand side of += or -= when used outside of the type 'LuaCollisionExitListener'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action<UnityEngine.Collision> ev = (System.Action<UnityEngine.Collision>)arg0.func;
				obj.OnEvent += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action<UnityEngine.Collision> ev = (System.Action<UnityEngine.Collision>)arg0.func;
				obj.OnEvent -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
