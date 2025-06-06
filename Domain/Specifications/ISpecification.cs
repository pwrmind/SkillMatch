﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specifications;

// Слой Domain
public interface ISpecification<T>
{
    bool IsSatisfiedBy(T entity);
}
