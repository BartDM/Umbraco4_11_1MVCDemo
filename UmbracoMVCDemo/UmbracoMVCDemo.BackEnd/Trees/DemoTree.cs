using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using umbraco.businesslogic;
using umbraco.cms.presentation.Trees;

namespace UmbracoMVCDemo.BackEnd.Trees
{
    [Tree("demo", "demo", "Demo")]
    public class DemoTree : umbraco.cms.presentation.Trees.BaseTree
    {
        public DemoTree(string application)
            : base(application)
        {
        }

        public override void RenderJS(ref StringBuilder Javascript)
        {
            Javascript.Append(
            @"function openDemoController() {
                UmbClientMgr.contentFrame('/Demo/DemoAdminSurface');
            }
            function openDemoController2(id) {
                UmbClientMgr.contentFrame('/Demo/DemoAdminSurface/Edit/id');
            }
            ");
        }

        public override void Render(ref XmlTree tree)
        {
            XmlTreeNode xNode = XmlTreeNode.Create(this);
            xNode.NodeID = "1";
            xNode.Text = "Demo Node 1";
            xNode.Action = "javascript:openDemoController();";
            xNode.Icon = "folder.gif";
            xNode.OpenIcon = "folder_o.gif";
            OnBeforeNodeRender(ref tree, ref xNode, EventArgs.Empty);
            if (xNode != null)
            {
                tree.Add(xNode);
                OnAfterNodeRender(ref tree, ref xNode, EventArgs.Empty);
            }

            XmlTreeNode xNode2 = XmlTreeNode.Create(this);
            xNode2.NodeID = "2";
            xNode2.Text = "Demo node 2";
            xNode2.Action = "javascript:openDemoController2("+1+");";
            xNode2.Icon = "folder.gif";
            xNode2.OpenIcon = "folder_o.gif";
            OnBeforeNodeRender(ref tree, ref xNode2, EventArgs.Empty);
            if (xNode2 != null)
            {
                tree.Add(xNode2);
                OnAfterNodeRender(ref tree, ref xNode2, EventArgs.Empty);
            }
        }

        protected override void CreateRootNode(ref XmlTreeNode rootNode)
        {
            rootNode.NodeType = "init" + TreeAlias;
            rootNode.NodeID = "init";
        }
    }
}