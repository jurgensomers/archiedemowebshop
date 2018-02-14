using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Archie.Webshop.Api.Models.Validation
{
    public static class RulesEngine
    {
        private static IDictionary<string, Func<object, bool>> Rules = new Dictionary<string, Func<object, bool>>();

        public static void AddRule<TModel>(string validationName, Func<TModel, bool> ruleAction)
        {
            if (Rules.Keys.Any(x => x == validationName))
                Rules[validationName] = (obj) => { return ruleAction((TModel) obj); };
            else
                Rules.Add(validationName, (obj) => { return ruleAction((TModel)obj);});
        }

        public static bool Execute<TModel>(string validationName, TModel model)
        {
            if (Rules.Keys.Any(x => x == validationName))
                return Rules[validationName](model);

            return false;
        }
    }
}
