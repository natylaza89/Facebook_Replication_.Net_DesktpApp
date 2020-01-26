using System;
using System.Reflection;
using System.Windows.Forms;

namespace DP_Task1.custom_components
{
    public class FormsRepository : PrototypeRepository<Form>
    {        // SINGLETON!! (private ctor and public static access using the generic singleton)
        private FormsRepository()
        {
            //populateRepositoryFromExecutingAssembly();
        }

        public static FormsRepository Instance { get { return Singleton<FormsRepository>.Instance; } }

        private Assembly m_Assembly = Assembly.GetExecutingAssembly();
        private void populateRepositoryFromExecutingAssembly()
        {
            foreach (Type type in m_Assembly.GetTypes())
            {
                if (type.IsSubclassOf(typeof(Form))
                    && type.IsPublic)
                {
                    this.AddPrototype(null, type);
                }
            }
        }

        protected override Form createPrototype(Type i_Type)
        {


            Form form = m_Assembly.CreateInstance(i_Type.FullName) as Form;
            m_Dictionary[i_Type] = form;
            return form;
        }
    }

}
