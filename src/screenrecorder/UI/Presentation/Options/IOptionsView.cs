﻿/*
 * Copyright (c) 2015 Mehrzad Chehraz (mehrzady@gmail.com)
 * Released under the MIT License
 * http://chehraz.ir/mit_license
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:

 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.

 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */
namespace Atf.ScreenRecorder.UI.Presentation {
   using Atf.ScreenRecorder.Configuration;
   using Atf.ScreenRecorder.Screen;
   using System;
   using System.Drawing;
   using System.Windows.Forms;
   interface IOptionsView : IView {
      event EventHandler Cancel;
      event EventHandler AboutVideCompressor;
      event EventHandler ConfigureVideoCompressor;
      event EventHandler Load;
      event EventHandler OK;
      event EventHandler VideoCompressorChanged;
      BoundsTracker BoundsTracker {
         get;
         set;
      }
      Keys CancelHotKey {
         get;
         set;
      }
      Configuration Configuration {
         get;
         set;
      } 
      IntPtr Handle {
         get;
      }
      bool GlobalHotKeys {
         get;
         set;
      }
      bool MinimuzeOnRecord {
         get;
         set;
      }
      string OutputDirectory {
         get;
         set;
      }
      Keys PauseHotKey {
         get;
         set;
      }
      bool RecordCursor {
         get;
         set;
      }
      Keys RecordHotKey {
         get;
         set;
      }
      object SelectedVideoCompressor {
         get;
         set;
      }
      Keys StopHotKey {
         get;
         set;
      }
      bool VideoCompressorQualitySupport {
         set;
      }
      string VideoCompressor {
         get;
         set;
      }
      object[] VideoCompressors {
         set;
      }
      int VideoFps {
         get;
         set;
      }
      int VideoQuality {
         get;
         set;
      }
   }
}