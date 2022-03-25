// Decompiled with JetBrains decompiler
// Type: FaceitAPI.Types.SimpleContainer`1
// Assembly: FaceitAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 992590FD-0347-4C76-9A00-8911E3195932
// Assembly location: C:\Users\ladye\source\repos\ConsoleApp5\ConsoleApp5\bin\Debug\FaceitAPI.dll

using System;
using System.Collections.Generic;

namespace Huit.FaceitAPI.Type
{
  public class SimpleContainer<OUT>
  {
    private Dictionary<System.Type, OUT> Instances;

    public SimpleContainer() => this.Instances = new Dictionary<System.Type, OUT>();

    protected void RegisterObject<T>(OUT obj)
    {
      if (this.Exist<T>())
        return;
      this.Instances.Add(typeof (T), obj);
    }

    protected void UnregisterObject<T>()
    {
      if (!this.Exist<T>())
        return;
      this.Instances.Remove(typeof (T));
    }

    protected void Set<T>(OUT obj)
    {
      if (!this.Exist<T>())
        return;
      this.Instances[typeof (T)] = obj;
    }

    protected OUT Get<T>()
    {
      if (this.Exist<T>())
        return this.Instances[typeof (T)];
      throw new ArgumentException(typeof (T).FullName + " not exist in this SimpleContainer");
    }

    protected I Get<T, I>() => (I) Convert.ChangeType((object) this.Get<T>(), typeof (I));

    protected bool Exist<T>() => this.Instances.ContainsKey(typeof (T));
  }
}
