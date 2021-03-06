﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LuaProxyWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaProxy), typeof(PureMVC.Patterns.Proxy.Proxy));
		L.RegFunction("OnRegister", OnRegister);
		L.RegFunction("OnRemove", OnRemove);
		L.RegFunction("New", _CreateLuaProxy);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Proxy", get_Proxy, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLuaProxy(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				string arg0 = ToLua.CheckString(L, 1);
				LuaProxy obj = new LuaProxy(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 2)
			{
				string arg0 = ToLua.CheckString(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				LuaProxy obj = new LuaProxy(arg0, arg1);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: LuaProxy.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnRegister(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaProxy obj = (LuaProxy)ToLua.CheckObject<LuaProxy>(L, 1);
			obj.OnRegister();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnRemove(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaProxy obj = (LuaProxy)ToLua.CheckObject<LuaProxy>(L, 1);
			obj.OnRemove();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Proxy(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LuaProxy obj = (LuaProxy)o;
			LuaInterface.LuaTable ret = obj.Proxy;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Proxy on a nil value");
		}
	}
}

