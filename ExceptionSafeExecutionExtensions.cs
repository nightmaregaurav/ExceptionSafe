namespace ExceptionSafe
{
    public static class ExceptionSafeExecutionExtensions
    {
        public static T? ExceptionSafeExecute<T>(this Func<T> func)
        {
            try
            {
                return func();
            }
            catch
            {
                return default;
            }
        }

        public static async Task<T?> ExceptionSafeExecute<T>(this Func<Task<T>> func)
        {
            try
            {
                return await func();
            }
            catch
            {
                return default;
            }
        }

        public static T? ExceptionSafeExecute<T, T1>(this Func<T1, T> func, T1 param1)
        {
            try
            {
                return func(param1);
            }
            catch
            {
                return default;
            }
        }

        public static async Task<T?> ExceptionSafeExecute<T, T1>(this Func<T1, Task<T>> func, T1 param1)
        {
            try
            {
                return await func(param1);
            }
            catch
            {
                return default;
            }
        }

        public static T? ExceptionSafeExecute<T, T1, T2>(this Func<T1, T2, T> func, T1 param1, T2 param2)
        {
            try
            {
                return func(param1, param2);
            }
            catch
            {
                return default;
            }
        }

        public static async Task<T?> ExceptionSafeExecute<T, T1, T2>(this Func<T1, T2, Task<T>> func, T1 param1, T2 param2)
        {
            try
            {
                return await func(param1, param2);
            }
            catch
            {
                return default;
            }
        }

        public static T? ExceptionSafeExecute<T, T1, T2, T3>(this Func<T1, T2, T3, T> func, T1 param1, T2 param2, T3 param3)
        {
            try
            {
                return func(param1, param2, param3);
            }
            catch
            {
                return default;
            }
        }

        public static async Task<T?> ExceptionSafeExecute<T, T1, T2, T3>(this Func<T1, T2, T3, Task<T>> func, T1 param1, T2 param2, T3 param3)
        {
            try
            {
                return await func(param1, param2, param3);
            }
            catch
            {
                return default;
            }
        }

        public static T? ExceptionSafeExecute<T, T1, T2, T3, T4>(this Func<T1, T2, T3, T4, T> func, T1 param1, T2 param2, T3 param3, T4 param4)
        {
            try
            {
                return func(param1, param2, param3, param4);
            }
            catch
            {
                return default;
            }
        }

        public static async Task<T?> ExceptionSafeExecute<T, T1, T2, T3, T4>(this Func<T1, T2, T3, T4, Task<T>> func, T1 param1, T2 param2, T3 param3, T4 param4)
        {
            try
            {
                return await func(param1, param2, param3, param4);
            }
            catch
            {
                return default;
            }
        }

        public static T? ExceptionSafeExecute<T, T1, T2, T3, T4, T5>(this Func<T1, T2, T3, T4, T5, T> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
        {
            try
            {
                return func(param1, param2, param3, param4, param5);
            }
            catch
            {
                return default;
            }
        }

        public static async Task<T?> ExceptionSafeExecute<T, T1, T2, T3, T4, T5>(this Func<T1, T2, T3, T4, T5, Task<T>> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
        {
            try
            {
                return await func(param1, param2, param3, param4, param5);
            }
            catch
            {
                return default;
            }
        }

        public static T? ExceptionSafeExecute<T, T1, T2, T3, T4, T5, T6>(this Func<T1, T2, T3, T4, T5, T6, T> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
        {
            try
            {
                return func(param1, param2, param3, param4, param5, param6);
            }
            catch
            {
                return default;
            }
        }

        public static async Task<T?> ExceptionSafeExecute<T, T1, T2, T3, T4, T5, T6>(this Func<T1, T2, T3, T4, T5, T6, Task<T>> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
        {
            try
            {
                return await func(param1, param2, param3, param4, param5, param6);
            }
            catch
            {
                return default;
            }
        }

        public static T? ExceptionSafeExecute<T, T1, T2, T3, T4, T5, T6, T7>(this Func<T1, T2, T3, T4, T5, T6, T7, T> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
        {
            try
            {
                return func(param1, param2, param3, param4, param5, param6, param7);
            }
            catch
            {
                return default;
            }
        }

        public static async Task<T?> ExceptionSafeExecute<T, T1, T2, T3, T4, T5, T6, T7>(this Func<T1, T2, T3, T4, T5, T6, T7, Task<T>> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
        {
            try
            {
                return await func(param1, param2, param3, param4, param5, param6, param7);
            }
            catch
            {
                return default;
            }
        }

        public static T? ExceptionSafeExecute<T, T1, T2, T3, T4, T5, T6, T7, T8>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8)
        {
            try
            {
                return func(param1, param2, param3, param4, param5, param6, param7, param8);
            }
            catch
            {
                return default;
            }
        }

        public static async Task<T?> ExceptionSafeExecute<T, T1, T2, T3, T4, T5, T6, T7, T8>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<T>> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8)
        {
            try
            {
                return await func(param1, param2, param3, param4, param5, param6, param7, param8);
            }
            catch
            {
                return default;
            }
        }

        public static T? ExceptionSafeExecute<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9)
        {
            try
            {
                return func(param1, param2, param3, param4, param5, param6, param7, param8, param9);
            }
            catch
            {
                return default;
            }
        }

        public static async Task<T?> ExceptionSafeExecute<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<T>> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9)
        {
            try
            {
                return await func(param1, param2, param3, param4, param5, param6, param7, param8, param9);
            }
            catch
            {
                return default;
            }
        }

        public static T? ExceptionSafeExecute<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9, T10 param10)
        {
            try
            {
                return func(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10);
            }
            catch
            {
                return default;
            }
        }

        public static async Task<T?> ExceptionSafeExecute<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<T>> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9, T10 param10)
        {
            try
            {
                return await func(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10);
            }
            catch
            {
                return default;
            }
        }

        public static T? ExceptionSafeExecute<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9, T10 param10, T11 param11)
        {
            try
            {
                return func(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11);
            }
            catch
            {
                return default;
            }
        }

        public static async Task<T?> ExceptionSafeExecute<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<T>> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9, T10 param10, T11 param11)
        {
            try
            {
                return await func(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11);
            }
            catch
            {
                return default;
            }
        }

        public static T? ExceptionSafeExecute<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9, T10 param10, T11 param11, T12 param12)
        {
            try
            {
                return func(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12);
            }
            catch
            {
                return default;
            }
        }

        public static async Task<T?> ExceptionSafeExecute<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<T>> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9, T10 param10, T11 param11, T12 param12)
        {
            try
            {
                return await func(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12);
            }
            catch
            {
                return default;
            }
        }

        public static T? ExceptionSafeExecute<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9, T10 param10, T11 param11, T12 param12, T13 param13)
        {
            try
            {
                return func(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13);
            }
            catch
            {
                return default;
            }
        }

        public static async Task<T?> ExceptionSafeExecute<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<T>> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9, T10 param10, T11 param11, T12 param12, T13 param13)
        {
            try
            {
                return await func(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13);
            }
            catch
            {
                return default;
            }
        }

        public static T? ExceptionSafeExecute<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9, T10 param10, T11 param11, T12 param12, T13 param13, T14 param14)
        {
            try
            {
                return func(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14);
            }
            catch
            {
                return default;
            }
        }

        public static async Task<T?> ExceptionSafeExecute<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<T>> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9, T10 param10, T11 param11, T12 param12, T13 param13, T14 param14)
        {
            try
            {
                return await func(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14);
            }
            catch
            {
                return default;
            }
        }

        public static T? ExceptionSafeExecute<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9, T10 param10, T11 param11, T12 param12, T13 param13, T14 param14, T15 param15)
        {
            try
            {
                return func(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15);
            }
            catch
            {
                return default;
            }
        }

        public static async Task<T?> ExceptionSafeExecute<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<T>> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9, T10 param10, T11 param11, T12 param12, T13 param13, T14 param14, T15 param15)
        {
            try
            {
                return await func(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15);
            }
            catch
            {
                return default;
            }
        }

        public static T? ExceptionSafeExecute<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9, T10 param10, T11 param11, T12 param12, T13 param13, T14 param14, T15 param15, T16 param16)
        {
            try
            {
                return func(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16);
            }
            catch
            {
                return default;
            }
        }

        public static async Task<T?> ExceptionSafeExecute<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<T>> func, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9, T10 param10, T11 param11, T12 param12, T13 param13, T14 param14, T15 param15, T16 param16)
        {
            try
            {
                return await func(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16);
            }
            catch
            {
                return default;
            }
        }

        public static void ExceptionSafeExecute(this Action action)
        {
            try
            {
                action();
            }
            catch
            {
                // ignored
            }
        }

        public static void ExceptionSafeExecute<T1>(this Action<T1> action, T1 param1)
        {
            try
            {
                action(param1);
            }
            catch
            {
                // ignored
            }
        }

        public static void ExceptionSafeExecute<T1, T2>(this Action<T1, T2> action, T1 param1, T2 param2)
        {
            try
            {
                action(param1, param2);
            }
            catch
            {
                // ignored
            }
        }

        public static void ExceptionSafeExecute<T1, T2, T3>(this Action<T1, T2, T3> action, T1 param1, T2 param2, T3 param3)
        {
            try
            {
                action(param1, param2, param3);
            }
            catch
            {
                // ignored
            }
        }

        public static void ExceptionSafeExecute<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 param1, T2 param2, T3 param3, T4 param4)
        {
            try
            {
                action(param1, param2, param3, param4);
            }
            catch
            {
                // ignored
            }
        }

        public static void ExceptionSafeExecute<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
        {
            try
            {
                action(param1, param2, param3, param4, param5);
            }
            catch
            {
                // ignored
            }
        }

        public static void ExceptionSafeExecute<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
        {
            try
            {
                action(param1, param2, param3, param4, param5, param6);
            }
            catch
            {
                // ignored
            }
        }

        public static void ExceptionSafeExecute<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
        {
            try
            {
                action(param1, param2, param3, param4, param5, param6, param7);
            }
            catch
            {
                // ignored
            }
        }

        public static void ExceptionSafeExecute<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8)
        {
            try
            {
                action(param1, param2, param3, param4, param5, param6, param7, param8);
            }
            catch
            {
                // ignored
            }
        }

        public static void ExceptionSafeExecute<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9)
        {
            try
            {
                action(param1, param2, param3, param4, param5, param6, param7, param8, param9);
            }
            catch
            {
                // ignored
            }
        }

        public static void ExceptionSafeExecute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9, T10 param10)
        {
            try
            {
                action(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10);
            }
            catch
            {
                // ignored
            }
        }

        public static void ExceptionSafeExecute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9, T10 param10, T11 param11)
        {
            try
            {
                action(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11);
            }
            catch
            {
                // ignored
            }
        }

        public static void ExceptionSafeExecute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9, T10 param10, T11 param11, T12 param12)
        {
            try
            {
                action(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12);
            }
            catch
            {
                // ignored
            }
        }

        public static void ExceptionSafeExecute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9, T10 param10, T11 param11, T12 param12, T13 param13)
        {
            try
            {
                action(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13);
            }
            catch
            {
                // ignored
            }
        }

        public static void ExceptionSafeExecute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9, T10 param10, T11 param11, T12 param12, T13 param13, T14 param14)
        {
            try
            {
                action(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14);
            }
            catch
            {
                // ignored
            }
        }

        public static void ExceptionSafeExecute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9, T10 param10, T11 param11, T12 param12, T13 param13, T14 param14, T15 param15)
        {
            try
            {
                action(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15);
            }
            catch
            {
                // ignored
            }
        }

        public static void ExceptionSafeExecute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9, T10 param10, T11 param11, T12 param12, T13 param13, T14 param14, T15 param15, T16 param16)
        {
            try
            {
                action(param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16);
            }
            catch
            {
                // ignored
            }
        }
    }
}
