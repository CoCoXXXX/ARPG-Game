﻿/*
 * DO NOT ALTER OR REMOVE COPYRIGHT NOTICES OR THIS HEADER.
 *
 * Copyright 2014 rocky, rockylin@qq.com
 *
 * 
 * DapperQ.NET is free .NET library: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * DapperQ.NET is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with DapperQ.NET.  If not, see <http://www.gnu.org/licenses/>.
 *
 * DapperQ.NET是一个自由.NET类库，您可以自由分发、修改其中的源代码或者重新发布它，
 * 新的任何修改后的重新发布版必须同样在遵守LGPL3或更后续的版本协议下发布.
 * 关于LGPL协议的细则请参考COPYING、COPYING.LESSER文件，
 * 您可以在DapperQ.NET的相关目录中获得LGPL协议的副本，
 * 如果没有找到，请连接到 http://www.gnu.org/licenses/ 查看。
 *
 * - Author: Rocky Lin
 * - Contact: rockylin@qq.com
 * - License: GNU Lesser General Public License (LGPL)
 * - Blog and source code availability: https://dapperq.codeplex.com/
 */
  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DapperQ.Parser
{
    internal class Numbic : IParser
    {
        public int Value { get; private set; }
        static readonly object lockor = new object();
        static volatile Numbic instance = null;
        public Numbic()
        {
            Value = 0;
        }
        internal override object Context { get { return Value; } }

        public override void Dispose()
        {
            Value = 0;
        }
        internal new Numbic Stack(Expression exp)
        {
            if (exp.NodeType == ExpressionType.Constant)
            {
                var m = (ConstantExpression)exp;
                Value = (int)m.Value;
            }
            return this;
        }

        internal static Numbic GetInstance()
        {
            if (instance != null)
            {
                return instance;
            }

            lock (lockor)
            {
                instance = new Numbic();
            }
            return instance;
        }
    }
}
