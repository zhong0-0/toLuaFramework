﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class PureMVC_Patterns_Command_SimpleCommandWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(PureMVC.Patterns.Command.SimpleCommand), typeof(PureMVC.Patterns.Observer.Notifier));
		L.RegFunction("Execute", Execute);
		L.RegFunction("New", _CreatePureMVC_Patterns_Command_SimpleCommand);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePureMVC_Patterns_Command_SimpleCommand(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				PureMVC.Patterns.Command.SimpleCommand obj = new PureMVC.Patterns.Command.SimpleCommand();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: PureMVC.Patterns.Command.SimpleCommand.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Execute(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PureMVC.Patterns.Command.SimpleCommand obj = (PureMVC.Patterns.Command.SimpleCommand)ToLua.CheckObject<PureMVC.Patterns.Command.SimpleCommand>(L, 1);
			PureMVC.Interfaces.INotification arg0 = (PureMVC.Interfaces.INotification)ToLua.CheckObject<PureMVC.Interfaces.INotification>(L, 2);
			obj.Execute(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

