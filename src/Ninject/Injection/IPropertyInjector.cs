﻿#region License
// Author: Nate Kohari <nate@enkari.com>
// Copyright (c) 2007-2009, Enkari, Ltd.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion
#region Using Directives
using System;
#endregion

namespace Ninject.Injection
{
	/// <summary>
	/// Injects values into a property.
	/// </summary>
	public interface IPropertyInjector
	{
		/// <summary>
		/// Injects the specified value into the property.
		/// </summary>
		/// <param name="target">The target object to inject.</param>
		/// <param name="value">The value to inject.</param>
		void Invoke(object target, object value);
	}
}