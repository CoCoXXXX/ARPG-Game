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

namespace DapperQ
{
    public static class LinqExtend
    {
        public static int Average(this int value) { return value; }
        public static long Average(this long value) { return value; }
        public static short Average(this short value) { return value; }
        public static decimal Average(this decimal value) { return value; }
        public static double Average(this double value) { return value; }
        public static float Average(this float value) { return value; }
        public static DateTime Average(this DateTime value) { return value; }

        public static int Sum(this int value) { return value; }
        public static long Sum(this long value) { return value; }
        public static short Sum(this short value) { return value; }
        public static decimal Sum(this decimal value) { return value; }
        public static double Sum(this double value) { return value; }
        public static float Sum(this float value) { return value; }
        public static DateTime Sum(this DateTime value) { return value; }


        public static int Max(this int value) { return value; }
        public static long Max(this long value) { return value; }
        public static short Max(this short value) { return value; }
        public static decimal Max(this decimal value) { return value; }
        public static double Max(this double value) { return value; }
        public static float Max(this float value) { return value; }
        public static DateTime Max(this DateTime value) { return value; }


        public static int Min(this int value) { return value; }
        public static long Min(this long value) { return value; }
        public static short Min(this short value) { return value; }
        public static decimal Min(this decimal value) { return value; }
        public static double Min(this double value) { return value; }
        public static float Min(this float value) { return value; }
        public static DateTime Min(this DateTime value) { return value; }
    }
}
