using System.Runtime.InteropServices;

namespace AppWinFormsCore.Forms
{
    public enum TypeOfForm
    {
        SomeTool1,
        SomeTool2,
        SomeToolsManagement
    }

    public static class FormFabricMethod
    {
        public static IFormSimple CreateForm(TypeOfForm formType)
        {
            switch (formType)
            {
                case TypeOfForm.SomeTool1: return CreateFormSomeTool1();
                case TypeOfForm.SomeTool2: return CreateFormSomeTool2();
                case TypeOfForm.SomeToolsManagement: return CreateFormSomeToolManagement();
            }

            return null;
        }

        private static IFormSimple CreateFormSomeTool1()
        {
            return new FSomeTools1();
        }

        private static IFormSimple CreateFormSomeTool2()
        {
            return new FSomeTools2();
        }

        private static IFormSimple CreateFormSomeToolManagement()
        {
            return new FSomeToolsManagement();
        }
    }

    public abstract class AbstractFabric
    {
        public abstract ScrollBar CreateScroller();
        public abstract Button CreateButton();
    }

    public class Fabric : AbstractFabric
    {
        private readonly AbstractFabric _fabric;

        public Fabric(AbstractFabric fabric)
        {
            this._fabric = fabric;
        }

        public override ScrollBar CreateScroller()
        {
            return this._fabric.CreateScroller();
        }

        public override Button CreateButton()
        {
            return this._fabric.CreateButton();
        }
    }

    public class IPhoneListFabric : AbstractFabric
    {
        public override ScrollBar CreateScroller()
        {
            throw new NotImplementedException();
        }

        public override Button CreateButton()
        {
            throw new NotImplementedException();
        }
    }

    public class AndroidListFabric : AbstractFabric
    {
        public override ScrollBar CreateScroller()
        {
            throw new NotImplementedException();
        }

        public override Button CreateButton()
        {
            throw new NotImplementedException();
        }
    }

    public class WindowsListFabric : AbstractFabric
    {
        public override ScrollBar CreateScroller()
        {
            throw new NotImplementedException();
        }

        public override Button CreateButton()
        {
            throw new NotImplementedException();
        }
    }
}
