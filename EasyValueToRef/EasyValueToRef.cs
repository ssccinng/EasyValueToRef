using System.Numerics;

namespace EasyValueToRef
{
    public class Ref<T>
    {
        private T _value;
        // 重载运算符使得他能和t直接+-
        //public static T operator +(Ref<T> r, T t)
        //{
        //    r.Value = t;
        //    return r.Value;
        //}
        public static implicit operator Ref<T>(T v)
        {
            return new Ref<T> { _value = v };
        }

        // 重载使得能够解构为T
        public static implicit operator T(Ref<T> r)
        {
            return r._value;
        }

        // 重载toString
        public override string ToString()
        {
            return _value.ToString() ?? string.Empty;
        }

        public static bool operator ==(Ref<T> r, Ref<T> t)
        {
            return r._value.Equals(t._value);
        }

        public static bool operator !=(Ref<T> r, Ref<T> t)
        {
            return !r._value.Equals(t._value);
        }

        public void SetValue(T value) { _value = value; }

        public override bool Equals(object obj)
        {
            return this == obj;
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }
    }
}
//    public class RefNum<T> : Ref<T> where T : struct, INumber<T>
//    {
//        //public static T operator +(RefNum<T> r, T t)
//        //{
//        //    return r.Value + t;
//        //}

//        public static implicit operator RefNum<T>(T v)
//        {
//            return new RefNum<T> { Value = v };
//        }

//        // 生成方法使之能够比较大小
//        public static bool operator >(RefNum<T> r, T t)
//        {
//            return r.Value.CompareTo(t) > 0;
//        }

//        public static bool operator <(RefNum<T> r, T t)
//        {
//            return r.Value.CompareTo(t) < 0;
//        }

//        // 生成方法使之能够比较是否相等
//        public static bool operator ==(RefNum<T> r, T t)
//        {
//            return r.Value.CompareTo(t) == 0;
//        }

//        public static bool operator !=(RefNum<T> r, T t)
//        {
//            return r.Value.CompareTo(t) != 0;
//        }
//    }
//}