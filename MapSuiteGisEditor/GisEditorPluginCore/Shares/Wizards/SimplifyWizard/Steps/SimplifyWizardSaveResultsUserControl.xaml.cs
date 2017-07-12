/*
* Licensed to the Apache Software Foundation (ASF) under one
* or more contributor license agreements.  See the NOTICE file
* distributed with this work for additional information
* regarding copyright ownership.  The ASF licenses this file
* to you under the Apache License, Version 2.0 (the
* "License"); you may not use this file except in compliance
* with the License.  You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/


using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Win32;

namespace ThinkGeo.MapSuite.GisEditor.Plugins
{
    /// <summary>
    /// Interaction logic for SaveResultsUserControl.xaml
    /// </summary>
    public partial class SimplifyWizardSaveResultsUserControl : UserControl
    {
        public SimplifyWizardSaveResultsUserControl()
        {
            InitializeComponent();
        }

        [Obfuscation]
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog { Filter = "Shape Files|*.shp" };
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                SimplifyWizardShareObject entity = DataContext as SimplifyWizardShareObject;
                if (entity != null)
                {
                    entity.OutputPathFileName = dialog.FileName;
                }
            }
        }

        [Obfuscation]
        private void TextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Button_Click(sender, e);
        }
    }
}