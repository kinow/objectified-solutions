﻿#region Licence
/*
 * The MIT License
 *
 * Copyright (c) 2008-2013, Andrew Gray
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */
#endregion
namespace objectified_solutions.parsers {
    public class CSProjLine {
        //Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "eStoreAdminBLL", "eStoreAdminBLL\eStoreAdminBLL.csproj", "{95B7703A-54F2-43FC-8664-E648E51B86E6}"
        public string Name { get; set; }
        public string RelativePath { get; set; }
        public string ProjectGuid { get; set; } //unique id
        
        public CSProjLine(string line) {
            string[] tokens = line.Split(' ');
            Name = Trim(tokens[2]);
            RelativePath = Trim(tokens[3]);
            ProjectGuid = TrimProjectGuid(tokens[4]);
        }

        private string Trim(string s) {
            return s.Substring(1, s.Length - 3);
        }

        private string TrimProjectGuid(string s) {
            return s.Substring(2, s.Length - 4);
        }
    }
}