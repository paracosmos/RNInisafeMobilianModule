using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Native.Test.Library.RNNativeTestLibrary
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNNativeTestLibraryModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNNativeTestLibraryModule"/>.
        /// </summary>
        internal RNNativeTestLibraryModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNNativeTestLibrary";
            }
        }
    }
}
