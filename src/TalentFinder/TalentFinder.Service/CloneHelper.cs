﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.Service
{
	public static class CloneHelper
	{
		/// <summary>
		/// Clones a object via shallow copy
		/// </summary>
		/// <typeparam name="T">Object Type to Clone</typeparam>
		/// <param name="obj">Object to Clone</param>
		/// <returns>New Object reference</returns>
		public static T CloneObject<T>(this T obj) where T : class
		{
			if(obj == null)
				return null;
			System.Reflection.MethodInfo inst = obj.GetType().GetMethod("MemberwiseClone",
				System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
			if(inst == null)
				return null;
			else
				return (T)inst.Invoke(obj, null);
		}
	}
}
