﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class PureMVC_Patterns_Observer_NotifierWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(PureMVC.Patterns.Observer.Notifier), typeof(System.Object));
		L.RegFunction("SendNotification", SendNotification);
		L.RegFunction("New", _CreatePureMVC_Patterns_Observer_Notifier);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePureMVC_Patterns_Observer_Notifier(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				PureMVC.Patterns.Observer.Notifier obj = new PureMVC.Patterns.Observer.Notifier();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: PureMVC.Patterns.Observer.Notifier.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendNotification(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				PureMVC.Patterns.Observer.Notifier obj = (PureMVC.Patterns.Observer.Notifier)ToLua.CheckObject<PureMVC.Patterns.Observer.Notifier>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				obj.SendNotification(arg0);
				return 0;
			}
			else if (count == 3)
			{
				PureMVC.Patterns.Observer.Notifier obj = (PureMVC.Patterns.Observer.Notifier)ToLua.CheckObject<PureMVC.Patterns.Observer.Notifier>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				obj.SendNotification(arg0, arg1);
				return 0;
			}
			else if (count == 4)
			{
				PureMVC.Patterns.Observer.Notifier obj = (PureMVC.Patterns.Observer.Notifier)ToLua.CheckObject<PureMVC.Patterns.Observer.Notifier>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				string arg2 = ToLua.CheckString(L, 4);
				obj.SendNotification(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: PureMVC.Patterns.Observer.Notifier.SendNotification");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
