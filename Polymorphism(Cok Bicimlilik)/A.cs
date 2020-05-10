using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Cok_Bicimlilik_
{
    public class A
    {
        public virtual string Method()
        {
            return "A içerik";
        }
    }

    public class B : A
    {
        public override string Method()
        {
            return "B içerik";
        }
    }

    public class C : A
    {
        public override string Method()
        {
            string str = base.Method();
            return str + "C classından gelen içerik";
        }
    }
}
// Çok Biçimlilik: Base(temel, miras veren) sınıf içerisindeki üyelerin derived(türetilmiş)    sınıflar içerisinde farklı şekilde(class'a göre) davranmasını sağlama yaklaşımıdır.
// C#'ta bir .cs uzantılı dosya class tutmak için vardır.
// Virtual: Gövdelerinin derived class tarafından değiştirilebilir hale getirilmesi için       tanımlanan üyelerdir.