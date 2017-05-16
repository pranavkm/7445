using System;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.ModelBinding;

public class ReferenceTypeBodyJsonBindingConvention : IActionModelConvention
{
    public void Apply(ActionModel action)
    {
        if (action == null)
        {
            throw new ArgumentNullException(nameof(action));
        }
        
        foreach (var parameter in action.Parameters)
        {
            if (!parameter.ParameterInfo.ParameterType.IsValueType && parameter.ParameterInfo.ParameterType.FullName != typeof(string).FullName)
            {
                parameter.BindingInfo = parameter.BindingInfo ?? new BindingInfo();
                parameter.BindingInfo.BindingSource = BindingSource.Body;
            }
        }
    }
}
