using System;
using System.Collections.Generic;
using System.Text;

namespace QMCoreApp.Infrastructure.SharedKernel
{
    public class DomainEntity<T> //Kiểu T để tùy biến kiểu dữ liệu của Id > Kiểu Generic(Kiểu tạm)
    {
        public T Id { get; set; }

        /// <summary>
        /// True If Identity have a Identity
        /// </summary>
        /// <returns></returns>
        public bool IsTransient()
        {
            return Id.Equals(default(T));
        }

    }
}
