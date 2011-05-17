using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Microsoft.VisualStudio.TemplateWizard;

namespace Migrator.Net_Templates.Tests
{
    [TestFixture]
    public class MigrationTemplateTests
    {
        [Test]
        public void RunStarted_DictionaryContainsReplacementText_TextShouldBeReplaced()
        {
            //Arrange
            SystemTime.Now = () => (new DateTime(2010, 10, 9, 13, 28, 15)).AddMilliseconds(14);
            var replacementsDictionary = new Dictionary<string, string>();
            var template = new MigrationTemplate();

            //Act
            template.RunStarted(null, replacementsDictionary, WizardRunKind.AsNewItem, null);
            var result = replacementsDictionary["$migrationId$"];

            //Assert
            Assert.AreEqual("20101009132815014", result);
        }

        [Test]
        public void RunStarted_DictionaryDoesNotContainsReplacementText_TextShouldBeAdded()
        {
            //Arrange
            SystemTime.Now = () => (new DateTime(2010, 10, 9, 13, 28, 15)).AddMilliseconds(14);
            var replacementsDictionary = new Dictionary<string, string>();
            replacementsDictionary.Add("$migrationId$", string.Empty);
            var template = new MigrationTemplate();

            //Act
            template.RunStarted(null, replacementsDictionary, WizardRunKind.AsNewItem, null);
            var result = replacementsDictionary["$migrationId$"];

            //Assert
            Assert.AreEqual("20101009132815014", result);
        }
			
    }
}
