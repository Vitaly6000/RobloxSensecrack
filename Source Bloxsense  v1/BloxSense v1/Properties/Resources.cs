using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace BloxSense_v1.Properties
{
    // Token: 0x02000006 RID: 6
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [DebuggerNonUserCode]
    [CompilerGenerated]
    internal class Resources
    {
        // Token: 0x06000042 RID: 66 RVA: 0x00005F9B File Offset: 0x00005F9B
        internal Resources()
        {
        }

        // Token: 0x17000001 RID: 1
        // (get) Token: 0x06000043 RID: 67 RVA: 0x00005FA8 File Offset: 0x00005FA8
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                bool flag = Resources.resourceMan == null;
                if (flag)
                {
                    ResourceManager resourceManager = new ResourceManager("BloxSense_v1.Properties.Resources", typeof(Resources).Assembly);
                    Resources.resourceMan = resourceManager;
                }
                return Resources.resourceMan;
            }
        }

        // Token: 0x17000002 RID: 2
        // (get) Token: 0x06000044 RID: 68 RVA: 0x00005FF0 File Offset: 0x00005FF0
        // (set) Token: 0x06000045 RID: 69 RVA: 0x00006007 File Offset: 0x00006007
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get
            {
                return Resources.resourceCulture;
            }
            set
            {
                Resources.resourceCulture = value;
            }
        }

        // Token: 0x04000046 RID: 70
        private static ResourceManager resourceMan;

        // Token: 0x04000047 RID: 71
        private static CultureInfo resourceCulture;
    }
}
