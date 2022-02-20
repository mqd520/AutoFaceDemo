using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using Autofac;

namespace AutoFacUtils
{
    /// <summary>
    /// Autofac Helper
    /// </summary>
    public class AutoFacHelper
    {
        public static ContainerBuilder Builder { get; private set; }

        /// <summary>
        /// Container
        /// </summary>
        public static IContainer Container { get; private set; }


        static AutoFacHelper()
        {

        }

        public static void Init()
        {
            Builder = new ContainerBuilder();
        }

        public static void Build()
        {
            Container = Builder.Build();
        }

        /// <summary>
        /// Init
        /// </summary>
        public static void LoadAssembly(IList<string> lsAssembly)
        {
            foreach (var item in lsAssembly)
            {
                Assembly asm = Assembly.Load(item);
                Builder.RegisterAssemblyTypes(asm).AsImplementedInterfaces().AsSelf();
            }
        }

        public static void LoadAssembly(IList<Assembly> lsAssembly)
        {
            foreach (var item in lsAssembly)
            {
                Builder.RegisterAssemblyTypes(item).AsImplementedInterfaces().AsSelf();
            }
        }

        /// <summary>
        /// Resolve
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }

        public static T ResolveNamed<T>(string serviceName)
        {
            return Container.ResolveNamed<T>(serviceName);
        }
    }
}
