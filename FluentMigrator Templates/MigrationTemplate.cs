using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TemplateWizard;
using EnvDTE;

namespace Migrator.Net_Templates
{
    public class MigrationTemplate : IWizard
    {
        // Methods
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        public void RunFinished()
        {
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            var migrationId = string.Format("{0:yyyyMMddHHmmssfff}", SystemTime.Now());
            if (replacementsDictionary.ContainsKey("$migrationId$"))
            {
                replacementsDictionary["$migrationId$"] = migrationId;
            }
            else
            {
                replacementsDictionary.Add("$migrationId$", migrationId);
            }
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return false;
        }
    }
}
