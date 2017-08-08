﻿//****************************************************************************
// Description:
// Author: hiramtan@live.com
//****************************************************************************
using System;
namespace HiFramework
{
    /// <summary>
    /// 表现层控制逻辑
    /// </summary>
    public interface IView : ITick, IMessageReceive
    {
        /// <summary>
        /// bind this view to its controller
        /// </summary>
        /// <typeparam name="T"></typeparam>
        IController Bind<T>() where T : IController, new();
    }
}