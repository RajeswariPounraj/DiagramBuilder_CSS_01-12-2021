﻿using System.Collections.Generic;
//using Syncfusion.Blazor.Diagrams;
using System.Collections.ObjectModel;
//using DiagramShapes = Syncfusion.Blazor.Diagrams.Shapes;
//using DiagramSegments = Syncfusion.Blazor.Diagrams.Segments;
using System.Threading.Tasks;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.Diagram;
using Syncfusion.Blazor.Diagram.SymbolPalette;

namespace ServerApplication
{
    public partial class DiagramSymbolpalette
    {
        private void InitializePalettes()
        {
            FlowShapeList = new DiagramObjectCollection<NodeBase>();
            CreatePaletteNode(FlowShapeType.Terminator, "Terminator");
            CreatePaletteNode(FlowShapeType.Process, "Process");
            CreatePaletteNode(FlowShapeType.Decision, "Decision");
            CreatePaletteNode(FlowShapeType.Document, "Document");
            CreatePaletteNode(FlowShapeType.PreDefinedProcess, "PredefinedProcess");
            CreatePaletteNode(FlowShapeType.PaperTap, "PunchedTape");
            CreatePaletteNode(FlowShapeType.DirectData, "DirectData");
            CreatePaletteNode(FlowShapeType.SequentialData, "SequentialData");
            CreatePaletteNode(FlowShapeType.Sort, "Sort");
            CreatePaletteNode(FlowShapeType.MultiDocument, "Multidocument");
            CreatePaletteNode(FlowShapeType.Collate, "Collate");
            CreatePaletteNode(FlowShapeType.SummingJunction, "SummingJunction");
            CreatePaletteNode(FlowShapeType.Or, "Or");
            CreatePaletteNode(FlowShapeType.InternalStorage, "InternalStorage");
            CreatePaletteNode(FlowShapeType.Extract, "Extract");

            BasicShapeList = new DiagramObjectCollection<NodeBase>();
            CreateBasicPaletteNode(BasicShapeType.Rectangle, "Rectangle");
            CreateBasicPaletteNode(BasicShapeType.Ellipse, "Ellipse");
            CreateBasicPaletteNode(BasicShapeType.Hexagon, "Hexagon");
            CreateBasicPaletteNode(BasicShapeType.Parallelogram, "Parallelogram");
            CreateBasicPaletteNode(BasicShapeType.Triangle, "Triangle");
            CreateBasicPaletteNode(BasicShapeType.Plus, "Plus");
            CreateBasicPaletteNode(BasicShapeType.Star, "Star");
            CreateBasicPaletteNode(BasicShapeType.Pentagon, "Pentagon");
            CreateBasicPaletteNode(BasicShapeType.Heptagon, "Heptagon");
            CreateBasicPaletteNode(BasicShapeType.Octagon, "Octagon");
            CreateBasicPaletteNode(BasicShapeType.Trapezoid, "Trapezoid");
            CreateBasicPaletteNode(BasicShapeType.Decagon, "Decagon");
            CreateBasicPaletteNode(BasicShapeType.RightTriangle, "RightTriangle");
            CreateBasicPaletteNode(BasicShapeType.Cylinder, "Cylinder");
            CreateBasicPaletteNode(BasicShapeType.Diamond, "Diamond");

            ConnectorList = new DiagramObjectCollection<NodeBase>();
            CreatePaletteConnector("Link1", ConnectorSegmentType.Orthogonal, DecoratorShape.Arrow);
            CreatePaletteConnector("Link2", ConnectorSegmentType.Orthogonal, DecoratorShape.None);
            CreatePaletteConnector("Link3", ConnectorSegmentType.Straight, DecoratorShape.Arrow);
            CreatePaletteConnector("Link4", ConnectorSegmentType.Straight, DecoratorShape.None);
            CreatePaletteConnector("Link5", ConnectorSegmentType.Bezier, DecoratorShape.Arrow);
            ConnectorPalette = new Palette() { Symbols = ConnectorList, Title = "Connectors", ID = "Connector Shapes", IconCss = "e-ddb-icons e-connector" };
        }

        //private void InitializeBPMNPalettes()
        //{

        //    BpmnShapeList = new DiagramObjectCollection<NodeBase>();

        //    Node startEventNode = new Node()
        //    {
        //        ID = "Start",
        //        Shape = new BpmnShape()
        //        {
        //            Type = Shapes.Bpmn,
        //            Shape = BpmnShapes.Event,
        //            Events = new BpmnSubEvent() { Event = BpmnEvents.Start, Trigger = BpmnTriggers.None }
        //        },
        //    };
        //    BpmnShapeList.Add(startEventNode);
        //    Node interEventNode = new Node()
        //    {
        //        ID = "Intermediate",
        //        Shape = new BpmnShape()
        //        {
        //            Type = Shapes.Bpmn,
        //            Shape = BpmnShapes.Event,
        //            Events = new BpmnSubEvent() { Event = BpmnEvents.Intermediate, Trigger = BpmnTriggers.None }
        //        },
        //    };
        //    BpmnShapeList.Add(interEventNode);
        //    Node endEventNode = new Node()
        //    {
        //        ID = "End",
        //        Shape = new BpmnShape()
        //        {

        //            Type = Shapes.Bpmn,
        //            Shape = BpmnShapes.Event,
        //            Events = new BpmnSubEvent() { Event = BpmnEvents.End, Trigger = BpmnTriggers.None }
        //        },
        //    };
        //    BpmnShapeList.Add(endEventNode);
        //    AddBpmnShape("Gateway Label", BpmnShapes.Gateway);
        //    Node taskNode = new Node()
        //    {
        //        ID = "Task",
        //        Shape = new BpmnShape()
        //        {
        //            Type = Shapes.Bpmn,
        //            Shape = BpmnShapes.Activity,
        //            Activity = new BpmnActivity() { Activity = BpmnActivities.Task }
        //        },
        //    };
        //    BpmnShapeList.Add(taskNode);
        //    Node transactionNode = new Node()
        //    {
        //        ID = "Transaction",
        //        Shape = new BpmnShape()
        //        {
        //            Type = Shapes.Bpmn,
        //            Shape = BpmnShapes.Activity,
        //            Activity = new BpmnActivity()
        //            {
        //                Activity = BpmnActivities.SubProcess,
        //                SubProcess = new BpmnSubProcess()
        //                {
        //                    Type = BpmnSubProcessTypes.Transaction,
        //                    Transaction = new BpmnTransactionSubProcess() { Success = { Visible = false }, Failure = { Visible = false }, Cancel = { Visible = false } }
        //                }
        //            }
        //        },
        //    };
        //    BpmnShapeList.Add(transactionNode);
        //    AddBpmnShape("Message Label", BpmnShapes.Message);
        //    AddBpmnShape("Data Object Label", BpmnShapes.DataObject);
        //    AddBpmnShape("Data Source Label", BpmnShapes.DataSource);
        //    AddBpmnShape("Activity", BpmnShapes.Activity);
        //    AddBpmnShape("NodeGroup Label", BpmnShapes.Group);
        //    BpmnShapePalette = new Palette() { Symbols = BpmnShapeList, Title = "BPMN Shapes", Id = "Bpmn Shapes", Expanded = false, IconCss = "e-ddb-icons e-flow" };
        //}
        private void InitializeHTMLPalettes()
        {
            HTMLShapeList = new DiagramObjectCollection<NodeBase>();
            CreateHTMLShape(Shapes.HTML, "node1checknode");
            CreateHTMLShape(Shapes.HTML, "node2checknode");
            HtmlShapePalette = new Palette() { Symbols = HTMLShapeList, Title = "HTML Shapes", ID = "Html Shapes", IsExpanded = false, IconCss = "e-ddb-icons e-flow" };
        }
        private void InitializeNativePalettes()
        {
            NativeShapeList = new DiagramObjectCollection<NodeBase>();
            CreateNativeShape(Shapes.SVG, "Nativenode1");
            CreateNativeShape(Shapes.SVG, "Nativenode2");
            NativeShapePalette = new Palette() { Symbols = NativeShapeList, Title = "Native Shapes", ID = "Native Shapes", IsExpanded = false, IconCss = "e-ddb-icons e-flow" };
        }

        private void CreateHTMLShape(Shapes HTML, string id)
        {
            Node diagramNode = new Node()
            {
                ID = id,
                Shape = new Shape() { Type = Shapes.HTML },
            };
            HTMLShapeList.Add(diagramNode);
        }

        private void CreateNativeShape(Shapes Native, string id)
        {
            Node diagramNode = new Node()
            {
                ID = id,
                Shape = new Shape() { Type = Shapes.SVG }
            };
            NativeShapeList.Add(diagramNode);
        }

        //private void AddBpmnShape(string id, BpmnShapes bpmn)
        //{
        //    Node startEventNode = new Node()
        //    {
        //        ID = id,
        //        Shape = new BpmnShape()
        //        {
        //            Type = Shapes.Bpmn,
        //            Shape = bpmn
        //        },
        //    };
        //    BpmnShapeList.Add(startEventNode);
        //}
        private void CreatePaletteConnector(string id, ConnectorSegmentType type, DecoratorShape decoratorShape)
        {
            Connector diagramConnector = new Connector()
            {
                ID = id,
                //PreviewSize = new SymbolSizeModel() { Width = 100, Height = 100 },
                Type = type,
                SourcePoint = new Syncfusion.Blazor.Diagram.DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new Syncfusion.Blazor.Diagram.DiagramPoint() { X = 60, Y = 60 },
                Style = new ShapeStyle() { StrokeWidth = 2 },
                TargetDecorator = new DecoratorSettings() { Shape = decoratorShape }
            };

            ConnectorList.Add(diagramConnector);
        }
        private void CreatePaletteNode(FlowShapeType flowShape, string id)
        {
            Node diagramNode = new Node()
            {
                ID = id,
                Shape = new FlowShape() { Type = Shapes.Flow, Shape = flowShape },
                Style = new ShapeStyle() { StrokeWidth = 2 }
            };
            FlowShapeList.Add(diagramNode);
        }
        private void CreateBasicPaletteNode(BasicShapeType basicShape, string id)
        {
            Node diagramNode = new Node()
            {
                ID = id,
                Shape = new BasicShape() { Type = Shapes.Basic, Shape = basicShape },
                Style = new ShapeStyle() { StrokeWidth = 2 }
            };
            BasicShapeList.Add(diagramNode);
        }
        public void InitializeNetworkShapes()
        {

            NetworkShapesList = new DiagramObjectCollection<NodeBase>();

            Node NetworkShapes0 = new Node()
            {
                ID = "uKVMSwitch1",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M2.1,32.8157654 C1.49248678,32.8157654 1,32.3232787 1,31.7157654 L1,16.1 C1,15.4924868 1.49248678,15 2.1,15 L47.9,15 C48.5075132,15 49,15.4924868 49,16.1 L49,31.7157654 C49,32.3232787 48.5075132,32.8157654 47.9,32.8157654 L2.1,32.8157654 Z"
                },
                Width = 48,
                Height = 17.815765380859375,
                OffsetX = 25,
                OffsetY = 23.907882690429688,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            NetworkShapesList.Add(NetworkShapes0);
            Node NetworkShapes1 = new Node()
            {
                ID = "uKVMSwitch2",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M47,30.8157654 L3,30.8157654 L3,17 L47,17 L47,30.8157654 Z M9.1875,26.0625 C9.1875,25.269 8.5435,24.625 7.75,24.625 C6.95554167,24.625 6.3125,25.269 6.3125,26.0625 C6.3125,26.856 6.95554167,27.5 7.75,27.5 C8.5435,27.5 9.1875,26.856 9.1875,26.0625 Z M19.25,26.0625 C19.25,25.269 18.606,24.625 17.8125,24.625 C17.0180417,24.625 16.375,25.269 16.375,26.0625 C16.375,26.856 17.0180417,27.5 17.8125,27.5 C18.606,27.5 19.25,26.856 19.25,26.0625 Z M13.5,26.0625 C13.5,25.269 12.856,24.625 12.0625,24.625 C11.2680417,24.625 10.625,25.269 10.625,26.0625 C10.625,26.856 11.2680417,27.5 12.0625,27.5 C12.856,27.5 13.5,26.856 13.5,26.0625 Z M23.5625,26.0625 C23.5625,25.269 22.9185,24.625 22.125,24.625 C21.3305417,24.625 20.6875,25.269 20.6875,26.0625 C20.6875,26.856 21.3305417,27.5 22.125,27.5 C22.9185,27.5 23.5625,26.856 23.5625,26.0625 Z M29.3125,26.0625 C29.3125,25.269 28.6685,24.625 27.875,24.625 C27.0805417,24.625 26.4375,25.269 26.4375,26.0625 C26.4375,26.856 27.0805417,27.5 27.875,27.5 C28.6685,27.5 29.3125,26.856 29.3125,26.0625 Z M33.625,26.0625 C33.625,25.269 32.981,24.625 32.1875,24.625 C31.3930417,24.625 30.75,25.269 30.75,26.0625 C30.75,26.856 31.3930417,27.5 32.1875,27.5 C32.981,27.5 33.625,26.856 33.625,26.0625 Z M39.375,26.0625 C39.375,25.269 38.731,24.625 37.9375,24.625 C37.1430417,24.625 36.5,25.269 36.5,26.0625 C36.5,26.856 37.1430417,27.5 37.9375,27.5 C38.731,27.5 39.375,26.856 39.375,26.0625 Z M43.6875,26.0625 C43.6875,25.269 43.0435,24.625 42.25,24.625 C41.4555417,24.625 40.8125,25.269 40.8125,26.0625 C40.8125,26.856 41.4555417,27.5 42.25,27.5 C43.0435,27.5 43.6875,26.856 43.6875,26.0625 Z"
                },
                Width = 44,
                Height = 13.815765380859375,
                OffsetX = 25,
                OffsetY = 23.907882690429688,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            NetworkShapesList.Add(NetworkShapes1);
            Node NetworkShapes2 = new Node()
            {
                ID = "uKVMSwitch3",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M9.1875,26.0625 C9.1875,26.856 8.5435,27.5 7.75,27.5 C6.95554167,27.5 6.3125,26.856 6.3125,26.0625 C6.3125,25.269 6.95554167,24.625 7.75,24.625 C8.5435,24.625 9.1875,25.269 9.1875,26.0625 Z M19.25,26.0625 C19.25,26.856 18.606,27.5 17.8125,27.5 C17.0180417,27.5 16.375,26.856 16.375,26.0625 C16.375,25.269 17.0180417,24.625 17.8125,24.625 C18.606,24.625 19.25,25.269 19.25,26.0625 Z M29.3125,26.0625 C29.3125,26.856 28.6685,27.5 27.875,27.5 C27.0805417,27.5 26.4375,26.856 26.4375,26.0625 C26.4375,25.269 27.0805417,24.625 27.875,24.625 C28.6685,24.625 29.3125,25.269 29.3125,26.0625 Z M39.375,26.0625 C39.375,26.856 38.731,27.5 37.9375,27.5 C37.1430417,27.5 36.5,26.856 36.5,26.0625 C36.5,25.269 37.1430417,24.625 37.9375,24.625 C38.731,24.625 39.375,25.269 39.375,26.0625 Z"
                },
                Width = 33.0625,
                Height = 2.875,
                OffsetX = 22.84375,
                OffsetY = 26.0625,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            NetworkShapesList.Add(NetworkShapes2);
            Node NetworkShapes3 = new Node()
            {
                ID = "uKVMSwitch4",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M6.3125,20.3125 L13.5,20.3125 L13.5,23.1875 L6.3125,23.1875 L6.3125,20.3125 Z M16.375,20.3125 L23.5625,20.3125 L23.5625,23.1875 L16.375,23.1875 L16.375,20.3125 Z M26.4375,20.3125 L33.625,20.3125 L33.625,23.1875 L26.4375,23.1875 L26.4375,20.3125 Z M36.5,20.3125 L43.6875,20.3125 L43.6875,23.1875 L36.5,23.1875 L36.5,20.3125 Z"
                },
                Width = 37.375,
                Height = 2.875,
                OffsetX = 25,
                OffsetY = 21.75,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            NetworkShapesList.Add(NetworkShapes3);
            NodeGroup NetworkShapes4 = new NodeGroup()
            {
                ID = "Switch",
                Children = new string[] {
               "uKVMSwitch1",
               "uKVMSwitch2",
               "uKVMSwitch3",
               "uKVMSwitch4"
            }
            };
            NetworkShapesList.Add(NetworkShapes4);
            Node NetworkShapes5 = new Node()
            {
                ID = "uSpacer1",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M2.1,33.3259514 C1.49248678,33.3259514 1,32.8334646 1,32.2259514 L1,16.1 C1,15.4924868 1.49248678,15 2.1,15 L47.9,15 C48.5075132,15 49,15.4924868 49,16.1 L49,32.2259514 C49,32.8334646 48.5075132,33.3259514 47.9,33.3259514 L2.1,33.3259514 Z"
                },
                Width = 48,
                Height = 18.325950622558594,
                OffsetX = 25,
                OffsetY = 24.162975311279297,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            NetworkShapesList.Add(NetworkShapes5);
            Node NetworkShapes6 = new Node()
            {
                ID = "uSpacer2",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M3 31.3259514 47 31.3259514 47 17 3 17"
                },
                Width = 44,
                Height = 14.325950622558594,
                OffsetX = 25,
                OffsetY = 24.162975311279297,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            NetworkShapesList.Add(NetworkShapes6);
            Node NetworkShapes7 = new Node()
            {
                ID = "uSpacer3",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M6.4516129,27.8709677 L6.4516129,20.4516129 L7.93548387,20.4516129 L7.93548387,27.8709677 L6.4516129,27.8709677 Z M24.2580645,27.8709677 L24.2580645,20.4516129 L25.7419355,20.4516129 L25.7419355,27.8709677 L24.2580645,27.8709677 Z M12.3870968,27.8709677 L12.3870968,20.4516129 L13.8709677,20.4516129 L13.8709677,27.8709677 L12.3870968,27.8709677 Z M30.1935484,27.8709677 L30.1935484,20.4516129 L31.6774194,20.4516129 L31.6774194,27.8709677 L30.1935484,27.8709677 Z M18.3225806,27.8709677 L18.3225806,20.4516129 L19.8064516,20.4516129 L19.8064516,27.8709677 L18.3225806,27.8709677 Z M36.1290323,27.8709677 L36.1290323,20.4516129 L37.6129032,20.4516129 L37.6129032,27.8709677 L36.1290323,27.8709677 Z M9.41935484,27.8709677 L9.41935484,20.4516129 L10.9032258,20.4516129 L10.9032258,27.8709677 L9.41935484,27.8709677 Z M27.2258065,27.8709677 L27.2258065,20.4516129 L28.7096774,20.4516129 L28.7096774,27.8709677 L27.2258065,27.8709677 Z M15.3548387,27.8709677 L15.3548387,20.4516129 L16.8387097,20.4516129 L16.8387097,27.8709677 L15.3548387,27.8709677 Z M33.1612903,27.8709677 L33.1612903,20.4516129 L34.6451613,20.4516129 L34.6451613,27.8709677 L33.1612903,27.8709677 Z M42.0645161,27.8709677 L42.0645161,20.4516129 L43.5483871,20.4516129 L43.5483871,27.8709677 L42.0645161,27.8709677 Z M21.2903226,27.8709677 L21.2903226,20.4516129 L22.7741935,20.4516129 L22.7741935,27.8709677 L21.2903226,27.8709677 Z M39.0967742,27.8709677 L39.0967742,20.4516129 L40.5806452,20.4516129 L40.5806452,27.8709677 L39.0967742,27.8709677 Z"
                },
                Width = 37.096771240234375,
                Height = 7.419355392456055,
                OffsetX = 24.999998569488525,
                OffsetY = 24.161290168762207,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            NetworkShapesList.Add(NetworkShapes7);
            NodeGroup NetworkShapes8 = new NodeGroup()
            {
                ID = "Spacer",
                Children = new string[] {
               "uSpacer1",
               "uSpacer2",
               "uSpacer3"
            }
            };
            NetworkShapesList.Add(NetworkShapes8);
            Node NetworkShapes9 = new Node()
            {
                ID = "uTray1",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M1,32.7098224 L1,15.1 C1,14.4924868 1.49248678,14 2.1,14 L47.9,14 C48.5075132,14 49,14.4924868 49,15.1 L49,32.7098224 C49,33.3173356 48.5075132,33.8098224 47.9,33.8098224 L2.1,33.8098224 C1.49248678,33.8098224 1,33.3173356 1,32.7098224 Z"
                },
                Width = 48,
                Height = 19.80982208251953,
                OffsetX = 25,
                OffsetY = 23.904911041259766,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            NetworkShapesList.Add(NetworkShapes9);
            Node NetworkShapes10 = new Node()
            {
                ID = "uTray2",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M3,31.8098224 L3,16 L47,16 L47,31.8098224 L3,31.8098224 Z M25.7419355,29.8387097 C29.0200127,29.8387097 31.6774194,27.181303 31.6774194,23.9032258 C31.6774194,20.6251486 29.0200127,17.9677419 25.7419355,17.9677419 C22.4638583,17.9677419 19.8064516,20.6251486 19.8064516,23.9032258 C19.8064516,27.181303 22.4638583,29.8387097 25.7419355,29.8387097 Z"
                },
                Width = 44,
                Height = 15.809822082519531,
                OffsetX = 25,
                OffsetY = 23.904911041259766,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            NetworkShapesList.Add(NetworkShapes10);
            Node NetworkShapes11 = new Node()
            {
                ID = "uTray3",
                Shape = new BasicShape()
                {
                    Type = Shapes.Basic,
                    Shape = BasicShapeType.Rectangle
                },
                Width = 2.9677419662475586,
                Height = 5.935483932495117,
                OffsetX = 25.74193525314331,
                OffsetY = 23.903225898742676,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            NetworkShapesList.Add(NetworkShapes11);
            NodeGroup NetworkShapes12 = new NodeGroup()
            {
                ID = "Tray",
                Children = new string[] {
               "uTray1",
               "uTray2",
               "uTray3"
            }
            };
            NetworkShapesList.Add(NetworkShapes12);
            Node NetworkShapes13 = new Node()
            {
                ID = "uLCDCopy1",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M2.1,30.6875 C1.49248678,30.6875 1,30.1950132 1,29.5875 L1,12.5342346 C1,11.9267213 1.49248678,11.4342346 2.1,11.4342346 L47.9,11.4342346 C48.5075132,11.4342346 49,11.9267213 49,12.5342346 L49,29.5875 C49,30.1950132 48.5075132,30.6875 47.9,30.6875 L2.1,30.6875 Z"
                },
                Width = 48,
                Height = 19.253265380859375,
                OffsetX = 25,
                OffsetY = 21.060867309570312,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            NetworkShapesList.Add(NetworkShapes13);
            Node NetworkShapes14 = new Node()
            {
                ID = "uLCDCopy2",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M3 28.6875 47 28.6875 47 13.4342346 3 13.4342346"
                },
                Width = 44,
                Height = 15.253265380859375,
                OffsetX = 25,
                OffsetY = 21.060867309570312,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            NetworkShapesList.Add(NetworkShapes14);
            Node NetworkShapes15 = new Node()
            {
                ID = "uLCDCopy3",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M6.3125,16.75 L9.1875,16.75 L9.1875,19.625 L6.3125,19.625 L6.3125,16.75 Z M6.3125,22.5 L9.1875,22.5 L9.1875,25.375 L6.3125,25.375 L6.3125,22.5 Z M12.0625,16.75 L14.9375,16.75 L14.9375,19.625 L12.0625,19.625 L12.0625,16.75 Z M12.0625,22.5 L14.9375,22.5 L14.9375,25.375 L12.0625,25.375 L12.0625,22.5 Z M17.8125,16.75 L20.6875,16.75 L20.6875,19.625 L17.8125,19.625 L17.8125,16.75 Z M17.8125,22.5 L20.6875,22.5 L20.6875,25.375 L17.8125,25.375 L17.8125,22.5 Z M23.5625,16.75 L26.4375,16.75 L26.4375,19.625 L23.5625,19.625 L23.5625,16.75 Z M23.5625,22.5 L26.4375,22.5 L26.4375,25.375 L23.5625,25.375 L23.5625,22.5 Z M29.3125,16.75 L32.1875,16.75 L32.1875,19.625 L29.3125,19.625 L29.3125,16.75 Z M29.3125,22.5 L32.1875,22.5 L32.1875,25.375 L29.3125,25.375 L29.3125,22.5 Z M35.0625,16.75 L37.9375,16.75 L37.9375,19.625 L35.0625,19.625 L35.0625,16.75 Z M35.0625,22.5 L37.9375,22.5 L37.9375,25.375 L35.0625,25.375 L35.0625,22.5 Z M40.8125,16.75 L43.6875,16.75 L43.6875,19.625 L40.8125,19.625 L40.8125,16.75 Z M40.8125,22.5 L43.6875,22.5 L43.6875,25.375 L40.8125,25.375 L40.8125,22.5 Z"
                },
                Width = 37.375,
                Height = 8.625,
                OffsetX = 25,
                OffsetY = 21.0625,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            NetworkShapesList.Add(NetworkShapes15);
            NodeGroup NetworkShapes16 = new NodeGroup()
            {
                ID = "LCD-Copy",
                Children = new string[] {
               "uLCDCopy1",
               "uLCDCopy2",
               "uLCDCopy3"
            }
            };
            NetworkShapesList.Add(NetworkShapes16);
            Node NetworkShapes17 = new Node()
            {
                ID = "uLCD1",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M2.1,45.3298502 C1.49248678,45.3298502 1,44.8373634 1,44.2298502 L1,7.6298502 C1,7.02233697 1.49248678,6.5298502 2.1,6.5298502 L47.9,6.5298502 C48.5075132,6.5298502 49,7.02233697 49,7.6298502 L49,44.2298502 C49,44.8373634 48.5075132,45.3298502 47.9,45.3298502 L2.1,45.3298502 Z"
                },
                Width = 48,
                Height = 38.79999923706055,
                OffsetX = 25,
                OffsetY = 25.92984962463379,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            NetworkShapesList.Add(NetworkShapes17);
            Node NetworkShapes18 = new Node()
            {
                ID = "uLCD2",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M3 43.3298502 47 43.3298502 47 8.5298502 3 8.5298502"
                },
                Width = 44,
                Height = 34.79999923706055,
                OffsetX = 25,
                OffsetY = 25.92984962463379,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            NetworkShapesList.Add(NetworkShapes18);
            Node NetworkShapes19 = new Node()
            {
                ID = "uLCD3",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M40.3333333,39.7298502 C40.3333333,38.8834502 41.0187333,38.1965169 41.8666667,38.1965169 C42.7146,38.1965169 43.4,38.8834502 43.4,39.7298502 C43.4,40.5762502 42.7146,41.2631835 41.8666667,41.2631835 C41.0187333,41.2631835 40.3333333,40.5762502 40.3333333,39.7298502 Z M35.7333333,39.7298502 C35.7333333,38.8834502 36.4187333,38.1965169 37.2666667,38.1965169 C38.1146,38.1965169 38.8,38.8834502 38.8,39.7298502 C38.8,40.5762502 38.1146,41.2631835 37.2666667,41.2631835 C36.4187333,41.2631835 35.7333333,40.5762502 35.7333333,39.7298502 Z M7.6,36.6631835 C7.04771525,36.6631835 6.6,36.2154683 6.6,35.6631835 L6.6,13.1298502 C6.6,12.5775654 7.04771525,12.1298502 7.6,12.1298502 L42.4,12.1298502 C42.9522847,12.1298502 43.4,12.5775654 43.4,13.1298502 L43.4,35.6631835 C43.4,36.2154683 42.9522847,36.6631835 42.4,36.6631835 L7.6,36.6631835 Z"
                },
                Width = 36.80000305175781,
                Height = 29.133333206176758,
                OffsetX = 25.000001430511475,
                OffsetY = 26.69651699066162,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            NetworkShapesList.Add(NetworkShapes19);
            NodeGroup NetworkShapes20 = new NodeGroup()
            {
                ID = "LCD",
                Children = new string[] {
               "uLCD1",
               "uLCD2",
               "uLCD3"
            }
            };
            NetworkShapesList.Add(NetworkShapes20);
            //Node NetworkShapes21 = new Node()
            //{
            //    ID = "CommLink1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M19.1164467,32.0512568 L9.15896529,32.0512568 C8.55145207,32.0512568 8.05896529,31.55877 8.05896529,30.9512568 C8.05896529,30.7863898 8.09602469,30.6236314 8.16740307,30.475017 L21.8615358,1.96294276 C22.1245558,1.41531807 22.7817132,1.18460036 23.3293379,1.44762034 C23.7105962,1.63073582 23.9530981,2.01622963 23.9530981,2.43918257 L23.9530981,20.0871442 L34.2786671,20.0871442 C34.8861803,20.0871442 35.3786671,20.5796309 35.3786671,21.1871442 C35.3786671,21.3623523 35.3368147,21.5350258 35.2565939,21.6907901 L21.6487306,48.1131089 C21.3705746,48.653203 20.7072519,48.8655457 20.1671579,48.5873897 C19.8111852,48.4040588 19.582948,48.0417783 19.5712716,47.6415403 L19.1164467,32.0512568 Z"
            //    },
            //    Width = 27.319700241088867,
            //    Height = 47.370765686035156,
            //    OffsetX = 21.718815803527832,
            //    OffsetY = 25.024311542510986,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes21);
            //Node NetworkShapes22 = new Node()
            //{
            //    ID = "CommLink2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M19.9905733,30.0512568 C20.5855953,30.0512568 21.072754,30.5244106 21.0901055,31.1191795 L21.4686463,44.0946297 L32.8028088,22.0871442 L23.0530981,22.0871442 C22.4455848,22.0871442 21.9530981,21.5946574 21.9530981,20.9871442 L21.9530981,6.3918257 L10.5896529,30.0512568 L19.9905733,30.0512568 Z"
            //    },
            //    Width = 22.213157653808594,
            //    Height = 37.70280456542969,
            //    OffsetX = 21.696231842041016,
            //    OffsetY = 25.2432279586792,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes22);
            //NodeGroup NetworkShapes23 = new NodeGroup()
            //{
            //    ID = "Comm-Link",
            //    Children = new string[] {
            //   "CommLink1",
            //   "CommLink2"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes23);
            //Node NetworkShapes24 = new Node()
            //{
            //    ID = "Copy Machine1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M40.7005552,45.6875 C40.354968,46.88754 39.2487473,47.7653634 37.9375,47.7653634 C36.6262527,47.7653634 35.520032,46.88754 35.1744448,45.6875 C35.1015528,45.4343848 35.0625,45.1669347 35.0625,44.8903634 L35.0625,44.6875 L22.125,44.6875 L22.125,44.8903634 C22.125,45.1669347 22.0859472,45.4343848 22.0130552,45.6875 C21.667468,46.88754 20.5612473,47.7653634 19.25,47.7653634 C17.9387527,47.7653634 16.832532,46.88754 16.4869448,45.6875 C16.4140528,45.4343848 16.375,45.1669347 16.375,44.8903634 L16.375,44.6875 L9.2875,44.6875 C8.67998678,44.6875 8.1875,44.1950132 8.1875,43.5875 L8.1875,29.5793168 C8.14845789,29.5636594 8.10996504,29.5453645 8.07224435,29.5243687 L1.5136506,25.8737644 C1.03108384,25.6051611 0.857632224,24.9962174 1.12623558,24.5136506 C1.39483893,24.0310838 2.00378263,23.8576322 2.4863494,24.1262356 L8.1875,27.2995751 L8.1875,22.3918168 C8.14845789,22.3761594 8.10996504,22.3578645 8.07224435,22.3368687 L1.5136506,18.6862644 C1.03108384,18.4176611 0.857632224,17.8087174 1.12623558,17.3261506 C1.39483893,16.8435838 2.00378263,16.6701322 2.4863494,16.9387356 L8.1875,20.1120751 L8.1875,19.35 C8.1875,19.316291 8.18901626,19.2829362 8.1919843,19.25 C8.18901626,19.2170638 8.1875,19.183709 8.1875,19.15 L8.1875,10.725 C8.1875,10.6190067 8.20249132,10.5165148 8.23046931,10.419529 C8.22536931,10.4026508 8.2206828,10.3855467 8.21642376,10.3682252 C8.08455493,9.83191461 8.41241977,9.29024816 8.94873036,9.15837933 L42.0112304,1.02892376 C42.547541,0.897054932 43.0892074,1.22491977 43.2210762,1.76123036 C43.3529451,2.29754096 43.0250802,2.83920741 42.4887696,2.97107624 L15.4272583,9.625 L43.125,9.625 C44.7818542,9.625 46.125,10.9681458 46.125,12.625 L46.125,18.25 L47.9,18.25 C48.5075132,18.25 49,18.7424868 49,19.35 L49,43.5875 C49,44.1950132 48.5075132,44.6875 47.9,44.6875 L40.8125,44.6875 L40.8125,44.8903634 C40.8125,45.1669347 40.7734472,45.4343848 40.7005552,45.6875 Z"
            //    },
            //    Width = 48.00018310546875,
            //    Height = 46.765594482421875,
            //    OffsetX = 24.999910056591034,
            //    OffsetY = 24.382563710212708,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes24);
            //Node NetworkShapes25 = new Node()
            //{
            //    ID = "Copy Machine2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M34.9375,28.875 L47,28.875 L47,42.6875 L10.1875,42.6875 L10.1875,28.875 L22,28.875 L22,34.625 C22,35.1772847 22.4477153,35.625 23,35.625 L33.9375,35.625 C34.4897847,35.625 34.9375,35.1772847 34.9375,34.625 L34.9375,28.875 Z M10.1875,26.875 L10.1875,20.25 L47,20.25 L47,26.875 L10.1875,26.875 Z M10.1875,18.25 L10.1875,11.625 L43.125,11.625 C43.6772847,11.625 44.125,12.0727153 44.125,12.625 L44.125,18.25 L10.1875,18.25 Z M24,29 L32.9375,29 L32.9375,33.625 L24,33.625 L24,29 Z"
            //    },
            //    Width = 36.8125,
            //    Height = 31.0625,
            //    OffsetX = 28.59375,
            //    OffsetY = 27.15625,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes25);
            //Node NetworkShapes26 = new Node()
            //{
            //    ID = "Copy Machine3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M40.8125,14.9375 C40.8125,15.731 40.1685,16.375 39.375,16.375 C38.5805417,16.375 37.9375,15.731 37.9375,14.9375 C37.9375,14.144 38.5805417,13.5 39.375,13.5 C40.1685,13.5 40.8125,14.144 40.8125,14.9375 Z M35.0625,14.9375 C35.0625,15.731 34.4185,16.375 33.625,16.375 C32.8305417,16.375 32.1875,15.731 32.1875,14.9375 C32.1875,14.144 32.8305417,13.5 33.625,13.5 C34.4185,13.5 35.0625,14.144 35.0625,14.9375 Z"
            //    },
            //    Width = 8.625,
            //    Height = 2.875,
            //    OffsetX = 36.5,
            //    OffsetY = 14.9375,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes26);
            //NodeGroup NetworkShapes27 = new NodeGroup()
            //{
            //    ID = "Copy Machine",
            //    Children = new string[] {
            //   "Copy Machine1",
            //   "Copy Machine2",
            //   "Copy Machine3"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes27);
            //Node NetworkShapes28 = new Node()
            //{
            //    ID = "CRTTv1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M39,41 L39,45.9 C39,46.5075132 38.5075132,47 37.9,47 L12.1,47 C11.4924868,47 11,46.5075132 11,45.9 L11,41 L3.1,41 C2.49248678,41 2,40.5075132 2,39.9 L2,4.1 C2,3.49248678 2.49248678,3 3.1,3 L46.9,3 C47.5075132,3 48,3.49248678 48,4.1 L48,39.9 C48,40.5075132 47.5075132,41 46.9,41 L39,41 Z M37,41 L13,41 L13,45 L37,45 L37,41 Z"
            //    },
            //    Width = 46,
            //    Height = 44,
            //    OffsetX = 25,
            //    OffsetY = 25,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes28);
            //Node NetworkShapes29 = new Node()
            //{
            //    ID = "CRTTv2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M4 39 46 39 46 5 4 5"
            //    },
            //    Width = 42,
            //    Height = 34,
            //    OffsetX = 25,
            //    OffsetY = 22,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes29);
            //Node NetworkShapes30 = new Node()
            //{
            //    ID = "CRTTv3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M40,35.5 C40,34.672 40.6705,34 41.5,34 C42.3295,34 43,34.672 43,35.5 C43,36.328 42.3295,37 41.5,37 C40.6705,37 40,36.328 40,35.5 Z M35,35.5 C35,34.672 35.6705,34 36.5,34 C37.3295,34 38,34.672 38,35.5 C38,36.328 37.3295,37 36.5,37 C35.6705,37 35,36.328 35,35.5 Z M8,32 C7.44771525,32 7,31.5522847 7,31 L7,9 C7,8.44771525 7.44771525,8 8,8 L42,8 C42.5522847,8 43,8.44771525 43,9 L43,31 C43,31.5522847 42.5522847,32 42,32 L8,32 Z"
            //    },
            //    Width = 36,
            //    Height = 29,
            //    OffsetX = 25,
            //    OffsetY = 22.5,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes30);
            //NodeGroup NetworkShapes31 = new NodeGroup()
            //{
            //    ID = "CRT-Tv",
            //    Children = new string[] {
            //   "CRTTv1",
            //   "CRTTv2",
            //   "CRTTv3"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes31);
            //Node NetworkShapes32 = new Node()
            //{
            //    ID = "Database1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M43.7344028,29.9565477 L41.7344029,29.9569448 L41.7299592,7.57595612 L43.7299592,7.57555903 L43.7344028,29.9565477 Z M42,29.6580305 L43.7344028,29.658746 L43.7333648,32.1746881 L43.7344029,32.1746881 C43.7344029,32.1926669 43.7340488,32.2106166 43.7333425,32.2285369 L43.7296629,41.1472256 C43.7296629,45.4824607 34.998229,47.9340463 24.3621504,47.9340463 C13.6983529,47.9340463 4.99888781,45.4668863 5.00296245,41.0712188 L5.00218258,32.2534405 C5.00071975,32.2271346 4.99999054,32.2007632 5.00000006,32.1743276 L5.00217559,32.1743284 L5.00113636,20.424083 C5.00037258,20.4050362 4.99999317,20.3859553 5.00000006,20.3668409 L5.00113129,20.3668413 L5.0000302,7.91704948 C5.00001007,7.91261564 5,7.90818025 5,7.90374332 C5,7.89947932 5.0000093,7.89521676 5.00002789,7.89095563 L5,7.57566913 L5.01854645,7.57566913 C5.46605995,3.63925821 13.9559515,1 24.3671866,1 C35.0651452,1 43.7344029,3.78658844 43.7344029,7.90374332 C43.7344029,9.00524477 43.1138802,10.0115078 42,10.8946498 L42,20.3672014 L43.7344029,20.3672014 C43.7344029,21.1199173 43.1137449,21.8216471 42,22.4461979 L42,29.6580305 Z"
            //    },
            //    Width = 38.73440170288086,
            //    Height = 46.93404769897461,
            //    OffsetX = 24.36720085144043,
            //    OffsetY = 24.467023849487305,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes32);
            //Node NetworkShapes33 = new Node()
            //{
            //    ID = "Database2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M41.7306587,11.0988624 L41.7324802,20.2732981 C41.7282415,20.2645969 41.7179482,20.2727076 41.6941516,20.296172 C41.5516118,20.4367218 41.300145,20.6069074 40.9512648,20.7869169 C40.1481641,21.2012877 38.9377433,21.6152325 37.4253016,21.9792559 C33.9735534,22.8100429 29.3456494,23.3030303 24.2207862,23.3030303 C19.1019156,23.3030303 14.5422408,22.8113279 11.1681459,21.9804958 C9.6963626,21.6180861 8.52382341,21.2058692 7.74906703,20.7930587 C7.41520325,20.6151674 7.17561326,20.4473515 7.04045839,20.3091219 C7.01414402,20.2822089 7.00446718,20.2745835 7.00112411,20.2877998 L7.00031132,11.0963621 C10.1641965,13.3953581 16.7516865,14.8074866 24.3671866,14.8074866 C31.9799744,14.8074866 38.5654471,13.3963845 41.7306587,11.0988624 Z M41.7329401,22.5896368 L41.7343628,29.755179 L41.7334023,32.0833768 C41.7298365,32.0709485 41.7198926,32.0783678 41.6941156,32.1037875 C41.5515821,32.2443454 41.3001249,32.4145354 40.9512524,32.5945471 C40.1481742,33.0089205 38.9377682,33.4228541 37.4253131,33.7868617 C33.9736694,34.6175802 29.3457522,35.1105169 24.2207862,35.1105169 C19.1018139,35.1105169 14.5421275,34.6188652 11.1681341,33.7881015 C9.69633824,33.4257077 8.52381369,33.013502 7.74907955,32.6006892 C7.41522344,32.4227959 7.17564278,32.2549757 7.04049371,32.1167381 C7.01647807,32.0921736 7.00631013,32.0836602 7.00216796,32.0923744 L7.00133035,22.6201558 C10.133462,24.2472733 16.6272769,25.3030303 24.2207862,25.3030303 C31.8913282,25.3030303 38.5466347,24.2306291 41.7329401,22.5896368 Z M41.7324475,34.3975145 L41.729663,41.1468131 C41.7296629,43.7011532 33.7771124,45.9340463 24.3621504,45.9340463 C14.9122976,45.9340463 7.00053532,43.6902781 7.00296202,41.0720572 L7.00237453,34.4283223 C10.1348322,36.0551226 16.6278699,37.1105169 24.2207862,37.1105169 C31.8911932,37.1105169 38.5460235,36.038356 41.7324475,34.3975145 Z M41.7344029,7.90374332 C41.7344029,10.3032023 33.9434117,12.8074866 24.3671866,12.8074866 C14.7910257,12.8074866 7,10.303194 7,7.90374332 C7,5.50429261 14.7910257,3 24.3671866,3 C33.9434117,3 41.7344029,5.50428429 41.7344029,7.90374332 Z"
            //    },
            //    Width = 34.73440170288086,
            //    Height = 42.93404769897461,
            //    OffsetX = 24.36720085144043,
            //    OffsetY = 24.467023849487305,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes33);
            //NodeGroup NetworkShapes34 = new NodeGroup()
            //{
            //    ID = "Database",
            //    Children = new string[] {
            //   "Database1",
            //   "Database2"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes34);
            //Node NetworkShapes35 = new Node()
            //{
            //    ID = "Encrypted1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M12.2211838,17.9196933 C11.9417924,16.8267991 11.7984667,15.6919871 11.7984667,14.5374533 C11.7984667,7.09155498 17.7799917,1.05425333 25.1651333,1.05425333 C32.550275,1.05425333 38.5318,7.09155498 38.5318,14.5374533 C38.5318,15.690297 38.3875278,16.8241907 38.1069428,17.9196933 L44.6636,17.9196933 L44.6636,47.7196933 L5.6636,47.7196933 L5.6636,17.9196933 L12.2211838,17.9196933 Z M14.5067095,17.9196933 L35.8212988,17.9196933 C36.1578478,16.8343735 36.3318,15.6981243 36.3318,14.5374533 C36.3318,8.30203396 31.3306541,3.25425333 25.1651333,3.25425333 C18.9996125,3.25425333 13.9984667,8.30203396 13.9984667,14.5374533 C13.9984667,15.7018028 14.1715279,16.8395732 14.5067095,17.9196933 Z"
            //    },
            //    Width = 39,
            //    Height = 46.66543960571289,
            //    OffsetX = 25.163599967956543,
            //    OffsetY = 24.3869731426239,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes35);
            //Node NetworkShapes36 = new Node()
            //{
            //    ID = "Encrypted2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M26.2666667,34.0408254 C27.4809125,33.6326429 28.3555583,32.4851303 28.3555583,31.1333333 C28.3555583,29.4396601 26.9825648,28.0666667 25.2888916,28.0666667 C23.5952184,28.0666667 22.2222249,29.4396601 22.2222249,31.1333333 C22.2222249,32.3925807 22.9812066,33.4745583 24.0666667,33.946763 L24.0666667,37.2666667 C24.0666667,37.8741799 24.5591534,38.3666667 25.1666667,38.3666667 C25.7741799,38.3666667 26.2666667,37.8741799 26.2666667,37.2666667 L26.2666667,34.0408254 Z M42.4636,45.5196933 L7.8636,45.5196933 L7.8636,20.1196933 L42.4636,20.1196933 L42.4636,45.5196933 Z"
            //    },
            //    Width = 34.599998474121094,
            //    Height = 25.39999771118164,
            //    OffsetX = 25.163599014282227,
            //    OffsetY = 32.819692611694336,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes36);
            //NodeGroup NetworkShapes37 = new NodeGroup()
            //{
            //    ID = "Encrypted",
            //    Children = new string[] {
            //   "Encrypted1",
            //   "Encrypted2"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes37);
            //Node NetworkShapes38 = new Node()
            //{
            //    ID = "External Storage1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M40,26 L40,31.9 C40,32.5075132 39.5075132,33 38.9,33 L3.1,33 C2.49248678,33 2,32.5075132 2,31.9 L2,6.1 C2,5.49248678 2.49248678,5 3.1,5 L38.9,5 C39.5075132,5 40,5.49248678 40,6.1 L40,24 L40.5,24 C45.2052326,24 49,27.5172076 49,32 C49,36.4827924 45.2052326,40 40.5,40 L34.8781758,40 C34.4508084,41.7189638 32.9475602,43 31.1428571,43 L23,43 L23,42 L20.1,42 C20.0447715,42 20,41.9552285 20,41.9 L20,36.1 C20,36.0447715 20.0447715,36 20.1,36 L23,36 L23,35 L31.1428571,35 C32.9475602,35 34.4508084,36.2810362 34.8781758,38 L40.5,38 C44.1331712,38 47,35.342859 47,32 C47,28.657141 44.1331712,26 40.5,26 L40,26 Z"
            //    },
            //    Width = 47,
            //    Height = 38,
            //    OffsetX = 25.5,
            //    OffsetY = 24,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes38);
            //Node NetworkShapes39 = new Node()
            //{
            //    ID = "External Storage2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M4,31 L4,7 L14,7 L14,31 L4,31 Z M7,10 L7,12 L11,12 L11,10 L7,10 Z M7,14 L7,16 L11,16 L11,14 L7,14 Z"
            //    },
            //    Width = 10,
            //    Height = 24,
            //    OffsetX = 9,
            //    OffsetY = 19,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes39);
            //Node NetworkShapes40 = new Node()
            //{
            //    ID = "External Storage3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M16,31 L16,7 L38,7 L38,31 L16,31 Z M25,41 L25,37 L31.1428571,37 C32.1565079,37 33,37.8856667 33,39 C33,40.1143333 32.1565079,41 31.1428571,41 L25,41 Z"
            //    },
            //    Width = 22,
            //    Height = 34,
            //    OffsetX = 27,
            //    OffsetY = 24,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes40);
            //NodeGroup NetworkShapes41 = new NodeGroup()
            //{
            //    ID = "External Storage",
            //    Children = new string[] {
            //   "External Storage1",
            //   "External Storage2",
            //   "External Storage3"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes41);
            Node NetworkShapes42 = new Node()
            {
                ID = "Fax1",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M21.3046875,9.21428571 L21.3046875,2.2953125 C21.3046875,1.96394165 21.5733167,1.6953125 21.9046875,1.6953125 L41.2649554,1.6953125 C41.5963262,1.6953125 41.8649554,1.96394165 41.8649554,2.2953125 L41.8649554,9.21428571 L46.6142857,9.21428571 C47.2217989,9.21428571 47.7142857,9.70677249 47.7142857,10.3142857 L47.7142857,47.9 C47.7142857,48.5075132 47.2217989,49 46.6142857,49 L4.1,49 C3.49248678,49 3,48.5075132 3,47.9 L3,10.3142857 C3,9.70677249 3.49248678,9.21428571 4.1,9.21428571 L21.3046875,9.21428571 Z"
                },
                Width = 44.71428680419922,
                Height = 47.3046875,
                OffsetX = 25.35714340209961,
                OffsetY = 25.34765625,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            NetworkShapesList.Add(NetworkShapes42);
            Node NetworkShapes43 = new Node()
            {
                ID = "Fax2",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M41.864603,16.2857143 C41.8648373,16.2788235 41.8649554,16.2719032 41.8649554,16.2649554 L41.8649554,10.5864662 L46.4285714,10.5864662 L46.4285714,47.6278195 L4.28571429,47.6278195 L4.28571429,10.5864662 L21.3046875,10.5864662 L21.3046875,16.2649554 C21.3046875,16.2719032 21.3048056,16.2788235 21.3050399,16.2857143 L20.4285714,16.2857143 C20.1524291,16.2857143 19.9285714,16.5095719 19.9285714,16.7857143 C19.9285714,17.0618567 20.1524291,17.2857143 20.4285714,17.2857143 L42.9685719,17.2857143 C43.2447142,17.2857143 43.4685719,17.0618567 43.4685719,16.7857143 C43.4685719,16.5095719 43.2447142,16.2857143 42.9685719,16.2857143 L41.864603,16.2857143 Z M10.0714286,40.9285714 C10.0714286,41.4808562 10.5191438,41.9285714 11.0714286,41.9285714 L16.6428571,41.9285714 C17.1951419,41.9285714 17.6428571,41.4808562 17.6428571,40.9285714 L17.6428571,17.2857143 C17.6428571,16.7334295 17.1951419,16.2857143 16.6428571,16.2857143 L11.0714286,16.2857143 C10.5191438,16.2857143 10.0714286,16.7334295 10.0714286,17.2857143 L10.0714286,40.9285714 Z M42.1534729,24.1534729 L42.1534729,20.2249015 C42.1534729,19.6726167 41.7057577,19.2249015 41.1534729,19.2249015 L22.7750985,19.2249015 C22.2228138,19.2249015 21.7750985,19.6726167 21.7750985,20.2249015 L21.7750985,24.1534729 C21.7750985,24.7057577 22.2228138,25.1534729 22.7750985,25.1534729 L41.1534729,25.1534729 C41.7057577,25.1534729 42.1534729,24.7057577 42.1534729,24.1534729 Z M23.7142857,30.4285714 L25.3571429,30.4285714 C25.6332852,30.4285714 25.8571429,30.2047138 25.8571429,29.9285714 C25.8571429,29.6524291 25.6332852,29.4285714 25.3571429,29.4285714 L23.7142857,29.4285714 C23.4381433,29.4285714 23.2142857,29.6524291 23.2142857,29.9285714 C23.2142857,30.2047138 23.4381433,30.4285714 23.7142857,30.4285714 Z M28.6428571,30.4285714 L30.2857143,30.4285714 C30.5618567,30.4285714 30.7857143,30.2047138 30.7857143,29.9285714 C30.7857143,29.6524291 30.5618567,29.4285714 30.2857143,29.4285714 L28.6428571,29.4285714 C28.3667148,29.4285714 28.1428571,29.6524291 28.1428571,29.9285714 C28.1428571,30.2047138 28.3667148,30.4285714 28.6428571,30.4285714 Z M33.5714286,30.4285714 L35.2142857,30.4285714 C35.4904281,30.4285714 35.7142857,30.2047138 35.7142857,29.9285714 C35.7142857,29.6524291 35.4904281,29.4285714 35.2142857,29.4285714 L33.5714286,29.4285714 C33.2952862,29.4285714 33.0714286,29.6524291 33.0714286,29.9285714 C33.0714286,30.2047138 33.2952862,30.4285714 33.5714286,30.4285714 Z M38.5,30.4285714 L40.1428571,30.4285714 C40.4189995,30.4285714 40.6428571,30.2047138 40.6428571,29.9285714 C40.6428571,29.6524291 40.4189995,29.4285714 40.1428571,29.4285714 L38.5,29.4285714 C38.2238576,29.4285714 38,29.6524291 38,29.9285714 C38,30.2047138 38.2238576,30.4285714 38.5,30.4285714 Z M23.7142857,33.7142857 L25.3571429,33.7142857 C25.6332852,33.7142857 25.8571429,33.4904281 25.8571429,33.2142857 C25.8571429,32.9381433 25.6332852,32.7142857 25.3571429,32.7142857 L23.7142857,32.7142857 C23.4381433,32.7142857 23.2142857,32.9381433 23.2142857,33.2142857 C23.2142857,33.4904281 23.4381433,33.7142857 23.7142857,33.7142857 Z M28.6428571,33.7142857 L30.2857143,33.7142857 C30.5618567,33.7142857 30.7857143,33.4904281 30.7857143,33.2142857 C30.7857143,32.9381433 30.5618567,32.7142857 30.2857143,32.7142857 L28.6428571,32.7142857 C28.3667148,32.7142857 28.1428571,32.9381433 28.1428571,33.2142857 C28.1428571,33.4904281 28.3667148,33.7142857 28.6428571,33.7142857 Z M33.5714286,33.7142857 L35.2142857,33.7142857 C35.4904281,33.7142857 35.7142857,33.4904281 35.7142857,33.2142857 C35.7142857,32.9381433 35.4904281,32.7142857 35.2142857,32.7142857 L33.5714286,32.7142857 C33.2952862,32.7142857 33.0714286,32.9381433 33.0714286,33.2142857 C33.0714286,33.4904281 33.2952862,33.7142857 33.5714286,33.7142857 Z M38.5,33.7142857 L40.1428571,33.7142857 C40.4189995,33.7142857 40.6428571,33.4904281 40.6428571,33.2142857 C40.6428571,32.9381433 40.4189995,32.7142857 40.1428571,32.7142857 L38.5,32.7142857 C38.2238576,32.7142857 38,32.9381433 38,33.2142857 C38,33.4904281 38.2238576,33.7142857 38.5,33.7142857 Z M23.7142857,37 L25.3571429,37 C25.6332852,37 25.8571429,36.7761424 25.8571429,36.5 C25.8571429,36.2238576 25.6332852,36 25.3571429,36 L23.7142857,36 C23.4381433,36 23.2142857,36.2238576 23.2142857,36.5 C23.2142857,36.7761424 23.4381433,37 23.7142857,37 Z M28.6428571,37 L30.2857143,37 C30.5618567,37 30.7857143,36.7761424 30.7857143,36.5 C30.7857143,36.2238576 30.5618567,36 30.2857143,36 L28.6428571,36 C28.3667148,36 28.1428571,36.2238576 28.1428571,36.5 C28.1428571,36.7761424 28.3667148,37 28.6428571,37 Z M33.5714286,37 L35.2142857,37 C35.4904281,37 35.7142857,36.7761424 35.7142857,36.5 C35.7142857,36.2238576 35.4904281,36 35.2142857,36 L33.5714286,36 C33.2952862,36 33.0714286,36.2238576 33.0714286,36.5 C33.0714286,36.7761424 33.2952862,37 33.5714286,37 Z M38.5,37 L40.1428571,37 C40.4189995,37 40.6428571,36.7761424 40.6428571,36.5 C40.6428571,36.2238576 40.4189995,36 40.1428571,36 L38.5,36 C38.2238576,36 38,36.2238576 38,36.5 C38,36.7761424 38.2238576,37 38.5,37 Z M23.7142857,40.2857143 L25.3571429,40.2857143 C25.6332852,40.2857143 25.8571429,40.0618567 25.8571429,39.7857143 C25.8571429,39.5095719 25.6332852,39.2857143 25.3571429,39.2857143 L23.7142857,39.2857143 C23.4381433,39.2857143 23.2142857,39.5095719 23.2142857,39.7857143 C23.2142857,40.0618567 23.4381433,40.2857143 23.7142857,40.2857143 Z M28.6428571,40.2857143 L30.2857143,40.2857143 C30.5618567,40.2857143 30.7857143,40.0618567 30.7857143,39.7857143 C30.7857143,39.5095719 30.5618567,39.2857143 30.2857143,39.2857143 L28.6428571,39.2857143 C28.3667148,39.2857143 28.1428571,39.5095719 28.1428571,39.7857143 C28.1428571,40.0618567 28.3667148,40.2857143 28.6428571,40.2857143 Z M33.5714286,40.2857143 L35.2142857,40.2857143 C35.4904281,40.2857143 35.7142857,40.0618567 35.7142857,39.7857143 C35.7142857,39.5095719 35.4904281,39.2857143 35.2142857,39.2857143 L33.5714286,39.2857143 C33.2952862,39.2857143 33.0714286,39.5095719 33.0714286,39.7857143 C33.0714286,40.0618567 33.2952862,40.2857143 33.5714286,40.2857143 Z M38.5,40.2857143 L40.1428571,40.2857143 C40.4189995,40.2857143 40.6428571,40.0618567 40.6428571,39.7857143 C40.6428571,39.5095719 40.4189995,39.2857143 40.1428571,39.2857143 L38.5,39.2857143 C38.2238576,39.2857143 38,39.5095719 38,39.7857143 C38,40.0618567 38.2238576,40.2857143 38.5,40.2857143 Z M41.1534729,24.1534729 L22.7750985,24.1534729 L22.7750985,20.2249015 L41.1534729,20.2249015 L41.1534729,24.1534729 Z M16.6428571,40.9285714 L11.0714286,40.9285714 L11.0714286,17.2857143 L16.6428571,17.2857143 L16.6428571,40.9285714 Z"
                },
                Width = 42.14285659790039,
                Height = 37.041351318359375,
                OffsetX = 25.357142448425293,
                OffsetY = 29.107141494750977,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            NetworkShapesList.Add(NetworkShapes43);
            Node NetworkShapes44 = new Node()
            {
                ID = "Fax3",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M38.1696429 18.5602679 38.1696429 0 25 2.22044605e-16 25 18.5602679"
                },
                Width = 13.16964340209961,
                Height = 18.56026840209961,
                OffsetX = 31.584821701049805,
                OffsetY = 9.280134201049805,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            NetworkShapesList.Add(NetworkShapes44);
            NodeGroup NetworkShapes45 = new NodeGroup()
            {
                ID = "Fax",
                Children = new string[] {
               "Fax1",
               "Fax2",
               "Fax3"
            }
            };
            NetworkShapesList.Add(NetworkShapes45);
            //Node NetworkShapes46 = new Node()
            //{
            //    ID = "Female User1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M32.3883936,33.6158313 C32.7279481,33.8870008 33.1167778,34.1042528 33.5420882,34.2554396 C34.2535291,34.5089621 35.2764603,34.9872516 36.6749429,35.6975273 C36.7948201,35.7584118 36.859902,35.791629 37.0440785,35.8859134 C37.3687153,36.05233 37.7000541,36.2238987 38.1137354,36.4393533 C38.1797559,36.4737383 38.8838396,36.8409696 39.0693667,36.9373725 C39.7313437,37.2813464 40.0985569,37.4657545 40.2645104,37.5361382 C42.4505398,38.4635979 44.1088201,40.0532873 45.3035168,42.0978034 C45.9829504,43.2605362 46.4705345,44.4977246 46.8010167,45.7341759 C47.0005327,46.480636 47.1047433,47.0704142 47.1437444,47.4290341 L47.2763068,48.6479615 L2.7737238,48.6479615 L2.90646346,47.4288908 C2.94551146,47.070277 3.04979671,46.4805056 3.24940258,45.7340536 C3.58003328,44.4976172 4.06775428,43.2604448 4.7472993,42.0977294 C5.9421899,40.0532473 7.60056331,38.4635868 9.78669561,37.5360834 C9.95252004,37.4657545 10.3197332,37.2813464 10.9817102,36.9373725 C11.1672373,36.8409696 11.871321,36.4737383 11.9373416,36.4393533 C12.3510228,36.2238987 12.6823616,36.05233 13.0069985,35.8859134 C13.1911749,35.791629 13.2562568,35.7584118 13.3761341,35.6975273 C14.7746166,34.9872516 15.7975478,34.5089621 16.5097956,34.2551524 C16.9625158,34.0942223 17.3739698,33.8582865 17.7287303,33.5617817 C17.1094045,33.522372 16.501305,33.4627998 15.918636,33.3795116 C14.4326449,33.1671004 13.2357534,32.8229877 12.4382649,32.3067216 C12.2150422,32.1789869 11.9318688,31.9647664 11.6509041,31.6486706 C10.7374963,30.6210525 10.5357406,29.2321001 11.4384351,27.7524092 C11.4629689,27.6615239 11.494072,27.5427309 11.5302426,27.3989542 C11.6327416,26.9915245 11.7354832,26.5408244 11.8313726,26.0609572 C12.0424021,25.0048842 12.189116,23.9648995 12.2430374,23.0038 C12.2700526,22.5222773 12.2728915,22.0709172 12.2498081,21.6546606 C12.1609864,20.0282636 12.1450194,19.0125719 12.2244817,17.9257914 C12.4695787,14.5268593 13.6674393,9.52144221 14.8403899,7.25868176 C15.1324356,6.37144387 15.8350711,5.17186013 17.1248401,3.99384201 C18.8164812,2.44877172 21.1299613,1.381035 24.1298516,0.990091005 C25.702166,0.786065703 27.2737015,0.927204891 28.7130289,1.42487175 C29.576781,1.72486308 30.0035947,1.99955353 30.5610125,2.56963099 C33.2821606,2.68815813 36.0927507,4.09644618 37.9943563,7.66498619 C38.2185525,8.16047954 38.5406915,9.02919412 38.8591901,10.1980663 C39.4630452,12.4141813 39.7876428,14.8056172 39.6862465,17.2235629 L39.7003983,25.0152468 C39.7019347,25.5998278 39.7741487,26.1819809 39.9152512,26.7479255 L39.9449818,26.8668573 C40.0421107,27.2587452 40.1885773,27.664512 40.4137313,28.1882831 C40.9333468,29.3933487 40.904933,30.6622652 39.9020567,31.6863789 L39.7414967,31.8216952 C39.3669228,32.080546 38.6797728,32.4292645 37.668765,32.7643268 C36.1884983,33.2549082 34.4267198,33.5634928 32.3883936,33.6158313 Z"
            //    },
            //    Width = 44.50258255004883,
            //    Height = 47.74802780151367,
            //    OffsetX = 25.025015115737915,
            //    OffsetY = 24.77394723892212,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes46);
            //Node NetworkShapes47 = new Node()
            //{
            //    ID = "Female User2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M28.9141962,31.6823892 L28.9451523,32.7296334 C29.3911888,34.0980802 30.4554452,35.1410186 31.7886353,35.6149324 C33.4153569,36.194616 37.4249479,38.299351 38.2137111,38.6338784 C43.3021355,40.7927281 44.934055,46.782329 44.934055,46.782329 L25.0250962,46.782329 L5.12012544,46.782329 C5.12012544,46.782329 6.50456832,40.7927281 11.5929927,38.6338784 C12.3817559,38.299351 16.3422076,36.194616 17.9689292,35.6149324 C19.3021193,35.1410186 20.3663757,34.0980802 20.8124122,32.7296334 L20.8434426,31.6798767 L20.3145456,31.679712 C20.3145456,31.679712 15.5958135,31.8093016 13.6879207,30.5786188 C13.6879207,30.5786188 11.8995848,29.5552793 13.1871198,27.6030753 C13.1871198,27.6030753 14.1862135,24.1459602 14.0315421,21.3568585 C13.9696735,20.2239949 13.9236901,19.0961477 14.0064602,17.9641202 C14.2213281,14.9843964 15.3157328,10.2397463 16.4051212,8.20978857 C16.4051212,8.20978857 17.7344592,3.77698954 24.3552317,2.91417389 C25.6502912,2.74612549 26.9787932,2.84979714 28.2119842,3.27618859 C28.9895216,3.54623652 29.2428483,3.77280923 29.6274366,4.17662702 C29.7628786,4.31875751 29.9468122,4.40487186 30.1441228,4.41072429 C31.1239871,4.43831433 34.3536933,4.82708301 36.3777986,8.62029485 C36.3777986,8.62029485 38.0850366,12.3934412 37.8843818,17.2275498 L37.8977588,24.5924172 C37.8994309,25.2286601 37.9780207,25.8623949 38.1318561,26.4794084 L38.1594461,26.5897685 C38.279839,27.0755204 38.4595922,27.5412067 38.6569028,28.0002046 C38.8926722,28.5469889 39.0958352,29.4415749 38.3851827,30.1672765 C38.3851827,30.1672765 36.0768164,31.7624822 31.0571021,31.6830563 L28.9141962,31.6823892 Z"
            //    },
            //    Width = 39.81393051147461,
            //    Height = 43.94465637207031,
            //    OffsetX = 25.027090549468994,
            //    OffsetY = 24.809999465942383,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes47);
            //NodeGroup NetworkShapes48 = new NodeGroup()
            //{
            //    ID = "Female User",
            //    Children = new string[] {
            //   "Female User1",
            //   "Female User2"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes48);
            //Node NetworkShapes49 = new Node()
            //{
            //    ID = "Firewall1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M22.7350317,45.0322581 L12.3870968,45.0322581 L12.3870968,37.6129032 L17.968999,37.6129032 C17.8254424,37.1275735 17.7045795,36.6325394 17.6076416,36.1290323 L15.3548387,36.1290323 L15.3548387,28.7096774 L17.9494229,28.7096774 C18.0965149,28.2041639 18.268199,27.7090789 18.463091,27.2258065 L12.3870968,27.2258065 L12.3870968,19.8064516 L24.6230502,19.8064516 C25.5495888,19.2133322 26.5419653,18.7142102 27.586684,18.3225806 L16.8387097,18.3225806 L16.8387097,10.9032258 L30.1935484,10.9032258 L30.1935484,17.5948445 C30.6806711,17.5032523 31.1756487,17.4340417 31.6773705,17.388323 L31.6774194,10.9032258 L45.0322581,10.9032258 L45.0322581,18.3225806 L38.6684045,18.3225806 C39.7132375,18.7142071 40.7057124,19.2133251 41.6323352,19.8064412 L45.0322581,19.8064516 L45.0322581,22.7352884 C47.4610414,25.5145126 48.9332258,29.1505692 48.9332258,33.1279032 C48.9332258,41.8515421 41.85115,48.9332258 33.1271613,48.9332258 C29.1500992,48.9332258 25.5141554,47.4610168 22.7350317,45.0322581 Z M2,9.41935484 L2,2 L31.6774194,2 L31.6774194,9.41935484 L2,9.41935484 Z M33.1612903,9.41935484 L33.1612903,2 L45.0322581,2 L45.0322581,9.41935484 L33.1612903,9.41935484 Z M2,45.0322581 L2,37.6129032 L10.9032258,37.6129032 L10.9032258,45.0322581 L2,45.0322581 Z M2,18.3225806 L2,10.9032258 L15.3548387,10.9032258 L15.3548387,18.3225806 L2,18.3225806 Z M2,27.2258065 L2,19.8064516 L10.9032258,19.8064516 L10.9032258,27.2258065 L2,27.2258065 Z M2,36.1290323 L2,28.7096774 L13.8709677,28.7096774 L13.8709677,36.1290323 L2,36.1290323 Z"
            //    },
            //    Width = 46.9332275390625,
            //    Height = 46.9332275390625,
            //    OffsetX = 25.46661376953125,
            //    OffsetY = 25.46661376953125,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes49);
            //Node NetworkShapes50 = new Node()
            //{
            //    ID = "Firewall2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M19.3225806,33.1279032 C19.3225806,25.5091683 25.5090399,19.3225806 33.1271613,19.3225806 C40.7465525,19.3225806 46.9332258,25.5089542 46.9332258,33.1279032 C46.9332258,40.7469478 40.7466053,46.9332258 33.1271613,46.9332258 C25.5089871,46.9332258 19.3225806,40.7467337 19.3225806,33.1279032 Z M28.0797886,34.5440051 C28.2240352,34.2433372 28.3679071,33.9943494 28.491645,33.8053288 C28.7326721,34.3201645 29.0288273,34.7310187 29.3691884,35.0469942 C29.9664952,35.6015063 30.5745727,35.7867197 31.0114648,35.7820105 L31.1979934,35.5702124 C30.8509776,32.2917526 31.3049828,29.9345537 32.2676538,28.34454 C32.500328,27.9602393 32.7470589,27.6503518 32.9939236,27.4074389 C32.9519275,27.6467085 32.9264092,27.898404 32.9162527,28.1612466 C32.8874528,28.9065734 32.9813091,29.7010666 33.1552338,30.4887862 C33.2466637,30.9028799 33.3383409,31.2225496 33.4002871,31.4062703 C34.2406332,33.1919653 34.8497472,34.6195633 35.2705319,35.7376548 C35.5217279,36.4051224 35.6540099,36.8194447 35.7020759,37.0086712 C36.069658,38.7242482 35.5881451,40.1491536 34.5551268,41.2952628 C34.2765464,41.6043411 33.9778243,41.868406 33.679431,42.0873228 C33.5016348,42.2177634 33.3648658,42.3034182 33.2897681,42.344402 L32.3771779,42.8424389 L33.4073711,42.7025693 C36.5717346,42.2729429 38.2737691,40.3310895 38.8140099,37.391021 C39.0760929,35.9647274 39.0405591,34.4457469 38.8236853,32.9998685 C38.7589023,32.5679653 38.6938908,32.2468909 38.649986,32.0679942 C38.5702807,31.8185204 38.5227016,31.4850718 38.5012454,31.0824106 C38.4808064,30.6988383 38.4851298,30.2867732 38.5047523,29.8924718 C38.5110131,29.7666661 38.5543335,29.2534932 38.5543335,29.2534932 C38.5543335,29.2534932 38.45193,29.3139084 38.2471229,29.4347388 C37.4535945,29.8169429 36.880221,30.6241197 36.4843173,31.7238991 C36.2910958,32.2606484 36.1526568,32.8337503 36.0595111,33.406561 C36.0553399,33.4322127 36.0513212,33.4574443 36.0474513,33.4822403 C35.5721461,32.4147753 35.1960359,31.4667944 34.9080217,30.6426248 C34.7030386,30.0560535 34.585508,29.6596846 34.5366934,29.460824 C34.1508837,27.9987707 34.4040704,26.6288739 35.0626754,25.410172 C35.3271201,24.9208358 35.5904316,24.5717063 35.7618735,24.3893499 L36.1531145,23.9732016 L35.5900438,24.0691197 C32.5606216,24.5851765 30.5909213,26.0301007 29.5000328,28.1129991 C29.0667781,28.9402382 28.7981158,29.8231865 28.6624463,30.7183081 C28.5859757,31.2228471 28.5589185,31.6750654 28.563343,32.0499944 C28.2619145,31.8831556 27.999623,31.6148694 27.7757178,31.2684707 C27.5307444,30.8894781 27.3811189,30.508162 27.31529,30.2601243 L27.1726715,29.7227495 L26.9538407,30.2338511 C24.5556339,35.835105 25.3479589,39.4792745 28.1437811,41.5382401 C28.7095156,41.9548717 29.3148454,42.2676097 29.9203188,42.4916986 C30.2849113,42.6266362 30.5703944,42.7024141 30.7377206,42.7336934 L31.650868,42.9043936 L30.8798525,42.3862123 C30.0842848,41.8515301 29.4359537,41.2893556 28.9257554,40.7033706 C27.1705708,38.6874644 27.1172397,36.5503439 28.0797886,34.5440051 Z"
            //    },
            //    Width = 27.610647201538086,
            //    Height = 27.610647201538086,
            //    OffsetX = 33.12790393829346,
            //    OffsetY = 33.12790393829346,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes50);
            //Node NetworkShapes51 = new Node()
            //{
            //    ID = "Firewall3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M17.968999,37.6129032 C18.829966,40.5236228 20.5071964,43.0852867 22.7350317,45.0322581 L12.3870968,45.0322581 L12.3870968,37.6129032 L17.968999,37.6129032 Z M30.1935484,17.5948445 C29.2955833,17.763686 28.4243099,18.0085832 27.586684,18.3225806 L16.8387097,18.3225806 L16.8387097,10.9032258 L30.1935484,10.9032258 L30.1935484,17.5948445 Z M31.6774194,17.3883185 L31.6774194,10.9032258 L45.0322581,10.9032258 L45.0322581,18.3225806 L38.6684045,18.3225806 C36.943751,17.6761425 35.0764404,17.3225806 33.1271613,17.3225806 C32.6384442,17.3225806 32.1548779,17.3448122 31.6774194,17.3883185 Z M24.6230502,19.8064516 C21.8709982,21.5681653 19.6997942,24.1591613 18.463091,27.2258065 L12.3870968,27.2258065 L12.3870968,19.8064516 L24.6230502,19.8064516 Z M41.6323514,19.8064516 L45.0322581,19.8064516 L45.0322581,22.7352884 C44.0453637,21.6060038 42.9005308,20.6181948 41.6323514,19.8064516 Z M17.9494229,28.7096774 C17.5413773,30.1120147 17.3225806,31.5946052 17.3225806,33.1279032 C17.3225806,34.1539388 17.4205521,35.1572659 17.6076416,36.1290323 L15.3548387,36.1290323 L15.3548387,28.7096774 L17.9494229,28.7096774 Z M2,9.41935484 L2,2 L31.6774194,2 L31.6774194,9.41935484 L2,9.41935484 Z M33.1612903,9.41935484 L33.1612903,2 L45.0322581,2 L45.0322581,9.41935484 L33.1612903,9.41935484 Z M2,45.0322581 L2,37.6129032 L10.9032258,37.6129032 L10.9032258,45.0322581 L2,45.0322581 Z M2,18.3225806 L2,10.9032258 L15.3548387,10.9032258 L15.3548387,18.3225806 L2,18.3225806 Z M2,27.2258065 L2,19.8064516 L10.9032258,19.8064516 L10.9032258,27.2258065 L2,27.2258065 Z M2,36.1290323 L2,28.7096774 L13.8709677,28.7096774 L13.8709677,36.1290323 L2,36.1290323 Z"
            //    },
            //    Width = 43.032257080078125,
            //    Height = 43.032257080078125,
            //    OffsetX = 23.516128540039062,
            //    OffsetY = 23.516128540039062,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes51);
            //NodeGroup NetworkShapes52 = new NodeGroup()
            //{
            //    ID = "Firewall",
            //    Children = new string[] {
            //   "Firewall1",
            //   "Firewall2",
            //   "Firewall3"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes52);
            //Node NetworkShapes53 = new Node()
            //{
            //    ID = "Flat screen tv1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M29.2857143,38.5 L32.9311905,38.5 C33.106822,38.5 33.2695754,38.5921494 33.359937,38.7427521 L37.6885084,45.9570378 C37.8305825,46.193828 37.7538,46.5009581 37.5170098,46.6430322 C37.4393021,46.6896568 37.3503839,46.7142857 37.259762,46.7142857 L12.740238,46.7142857 C12.4640957,46.7142857 12.240238,46.4904281 12.240238,46.2142857 C12.240238,46.1236637 12.264867,46.0347455 12.3114916,45.9570378 L16.640063,38.7427521 C16.7304246,38.5921494 16.893178,38.5 17.0688095,38.5 L20.7142857,38.5 L20.7142857,34.5714286 L2.1,34.5714286 C1.49248678,34.5714286 1,34.0789418 1,33.4714286 L1,4.1 C1,3.49248678 1.49248678,3 2.1,3 L47.9,3 C48.5075132,3 49,3.49248678 49,4.1 L49,33.4714286 C49,34.0789418 48.5075132,34.5714286 47.9,34.5714286 L29.2857143,34.5714286 L29.2857143,38.5 Z M27.2857143,38.5 L27.2857143,34.5714286 L22.7142857,34.5714286 L22.7142857,38.5 L27.2857143,38.5 Z M32.081905,40.5 L17.918095,40.5 L15.3895236,44.7142857 L34.6104764,44.7142857 L32.081905,40.5 Z"
            //    },
            //    Width = 48,
            //    Height = 43.71428680419922,
            //    OffsetX = 25,
            //    OffsetY = 24.85714340209961,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes53);
            //Node NetworkShapes54 = new Node()
            //{
            //    ID = "Flat screen tv2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M3 32.5714286 47 32.5714286 47 5 3 5"
            //    },
            //    Width = 44,
            //    Height = 27.571430206298828,
            //    OffsetX = 25,
            //    OffsetY = 18.785715103149414,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes54);
            //NodeGroup NetworkShapes55 = new NodeGroup()
            //{
            //    ID = "Flat Screen TV",
            //    Children = new string[] {
            //   "Flat screen tv1",
            //   "Flat screen tv2"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes55);
            //Node NetworkShapes56 = new Node()
            //{
            //    ID = "Gamepad Console1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M29.588574,31.2935933 L20.3683355,31.2935933 C16.9374574,37.428783 11.9181896,41.2574098 7.43675942,39.9793743 C1.52715219,38.2943393 -0.486976927,28.3185983 2.0622321,19.3792885 C4.42308864,11.0996616 10.3035639,6.61271554 16.451654,8.36560943 C17.9822379,8.80212683 19.3454222,9.60135423 20.4697888,10.7150178 C20.6207903,10.8645415 20.7896476,10.9377201 20.9429566,10.9377201 L29.0138444,10.9377201 C29.16725,10.9377201 29.3357823,10.8646954 29.4864964,10.7154246 C30.6112375,9.60138738 31.9745316,8.80212786 33.5052992,8.36559665 C39.6532268,6.61270891 45.5337019,11.0996548 47.8946692,19.3792637 C50.4437684,28.3186269 48.4296465,38.2943319 42.5202223,39.9793534 C38.0386656,41.2573861 33.0195557,37.4288916 29.588574,31.2935933 Z"
            //    },
            //    Width = 47.99850082397461,
            //    Height = 32.23584747314453,
            //    OffsetX = 24.9784197807312,
            //    OffsetY = 24.107128143310547,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes56);
            //Node NetworkShapes57 = new Node()
            //{
            //    ID = "Gamepad Console2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M11.7222197,22.9381958 L11.7222197,26.2391544 L13.5222197,26.2391544 L13.5222197,22.9381958 L16.8231783,22.9381958 L16.8231783,21.1381958 L13.5222197,21.1381958 L13.5222197,17.8372371 L11.7222197,17.8372371 L11.7222197,21.1381958 L8.42126102,21.1381958 L8.42126102,22.9381958 L11.7222197,22.9381958 Z M34.0537761,10.2889201 C38.7368786,8.95368107 43.7848591,12.2600128 45.9713371,19.9277103 C48.1578152,27.5954079 46.6548396,36.7206859 41.9717371,38.0560323 C38.4396103,39.0633103 34.1089371,35.349925 31.2549469,30.1747738 C30.9519908,29.6253103 30.3647517,29.2935933 29.7374835,29.2935933 L20.2194249,29.2935933 C19.5921566,29.2935933 19.0049176,29.6253103 18.7019615,30.1747738 C15.8479713,35.349925 11.5171908,39.0633103 7.98517126,38.0560323 C3.3019615,36.7206859 1.79898589,27.5954079 3.98557126,19.9277103 C6.17194199,12.2600128 11.2199225,8.95368107 15.9031322,10.2889201 C17.1174249,10.6352323 18.1831908,11.2651835 19.0625469,12.1361689 C19.5669371,12.6356225 20.2331615,12.9377201 20.9429566,12.9377201 L29.0138444,12.9377201 C29.7236396,12.9377201 30.3896493,12.6358372 30.8939322,12.1363835 C31.773503,11.2651835 32.8393761,10.6352323 34.0537761,10.2889201 Z M38.372549,18.1960784 C38.372549,17.243099 37.6000383,16.4705882 36.6470588,16.4705882 C35.6940794,16.4705882 34.9215686,17.243099 34.9215686,18.1960784 C34.9215686,19.1490579 35.6940794,19.9215686 36.6470588,19.9215686 C37.6000383,19.9215686 38.372549,19.1490579 38.372549,18.1960784 Z M36.6470588,23.372549 C35.6940794,23.372549 34.9215686,24.1450597 34.9215686,25.0980392 C34.9215686,26.0509344 35.6940794,26.8235294 36.6470588,26.8235294 C37.6000383,26.8235294 38.372549,26.0509344 38.372549,25.0980392 C38.372549,24.1450597 37.6000383,23.372549 36.6470588,23.372549 Z M40.0980392,19.9215686 C39.1450597,19.9215686 38.372549,20.6940794 38.372549,21.6470588 C38.372549,22.6000383 39.1450597,23.372549 40.0980392,23.372549 C41.0510187,23.372549 41.8235294,22.6000383 41.8235294,21.6470588 C41.8235294,20.6940794 41.0510187,19.9215686 40.0980392,19.9215686 Z M33.1960784,19.9215686 C32.243099,19.9215686 31.4705882,20.6940794 31.4705882,21.6470588 C31.4705882,22.6000383 32.243099,23.372549 33.1960784,23.372549 C34.1489737,23.372549 34.9215686,22.6000383 34.9215686,21.6470588 C34.9215686,20.6940794 34.1489737,19.9215686 33.1960784,19.9215686 Z M20.4926829,16.4833463 L24.2092878,16.4833463 L24.2092878,14.9365854 L20.4926829,14.9365854 L20.4926829,16.4833463 Z M25.7512195,16.4833463 L29.4677171,16.4833463 L29.4677171,14.9365854 L25.7512195,14.9365854 L25.7512195,16.4833463 Z"
            //    },
            //    Width = 43.95684051513672,
            //    Height = 28.221424102783203,
            //    OffsetX = 24.97842025756836,
            //    OffsetY = 24.1107120513916,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes57);
            //NodeGroup NetworkShapes58 = new NodeGroup()
            //{
            //    ID = "Gamepad Console",
            //    Children = new string[] {
            //   "Gamepad Console1",
            //   "Gamepad Console2"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes58);
            //Node NetworkShapes59 = new Node()
            //{
            //    ID = "Hub1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M40.1570187,33.6875 C40.2214158,33.8196495 40.2575478,33.9681052 40.2575478,34.125 C40.2575478,34.6772847 39.8098326,35.125 39.2575478,35.125 L10.625,35.125 C10.0727153,35.125 9.625,34.6772847 9.625,34.125 C9.625,33.9681052 9.66113207,33.8196495 9.72552911,33.6875 L2.1,33.6875 C1.49248678,33.6875 1,33.1950132 1,32.5875 L1,14.1 C1,13.4924868 1.49248678,13 2.1,13 L47.9,13 C48.5075132,13 49,13.4924868 49,14.1 L49,32.5875 C49,33.1950132 48.5075132,33.6875 47.9,33.6875 L40.1570187,33.6875 Z"
            //    },
            //    Width = 48,
            //    Height = 22.125,
            //    OffsetX = 25,
            //    OffsetY = 24.0625,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes59);
            //Node NetworkShapes60 = new Node()
            //{
            //    ID = "Hub2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M3,31.6875 L3,15 L47,15 L47,31.6875 L3,31.6875 Z M37.9375,23.34375 C37.9375,22.1535 36.9715,21.1875 35.78125,21.1875 C34.5895625,21.1875 33.625,22.1535 33.625,23.34375 C33.625,24.534 34.5895625,25.5 35.78125,25.5 C36.9715,25.5 37.9375,24.534 37.9375,23.34375 Z M43.6875,23.34375 C43.6875,22.1535 42.7215,21.1875 41.53125,21.1875 C40.3395625,21.1875 39.375,22.1535 39.375,23.34375 C39.375,24.534 40.3395625,25.5 41.53125,25.5 C42.7215,25.5 43.6875,24.534 43.6875,23.34375 Z"
            //    },
            //    Width = 44,
            //    Height = 16.6875,
            //    OffsetX = 25,
            //    OffsetY = 23.34375,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes60);
            //Node NetworkShapes61 = new Node()
            //{
            //    ID = "Hub3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M27.875,26.9375 L27.875,28.375 L25,28.375 L25,26.9375 L23.5625,26.9375 L23.5625,24.0625 L29.3125,24.0625 L29.3125,26.9375 L27.875,26.9375 Z M27.875,21.1875 L27.875,22.625 L25,22.625 L25,21.1875 L23.5625,21.1875 L23.5625,18.3125 L29.3125,18.3125 L29.3125,21.1875 L27.875,21.1875 Z M19.25,26.9375 L19.25,28.375 L16.375,28.375 L16.375,26.9375 L14.9375,26.9375 L14.9375,24.0625 L20.6875,24.0625 L20.6875,26.9375 L19.25,26.9375 Z M19.25,21.1875 L19.25,22.625 L16.375,22.625 L16.375,21.1875 L14.9375,21.1875 L14.9375,18.3125 L20.6875,18.3125 L20.6875,21.1875 L19.25,21.1875 Z M10.625,26.9375 L10.625,28.375 L7.75,28.375 L7.75,26.9375 L6.3125,26.9375 L6.3125,24.0625 L12.0625,24.0625 L12.0625,26.9375 L10.625,26.9375 Z M10.625,21.1875 L10.625,22.625 L7.75,22.625 L7.75,21.1875 L6.3125,21.1875 L6.3125,18.3125 L12.0625,18.3125 L12.0625,21.1875 L10.625,21.1875 Z"
            //    },
            //    Width = 23,
            //    Height = 10.0625,
            //    OffsetX = 17.8125,
            //    OffsetY = 23.34375,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes61);
            //Node NetworkShapes62 = new Node()
            //{
            //    ID = "Hub4",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M37.9375,23.34375 C37.9375,24.534 36.9715,25.5 35.78125,25.5 C34.5895625,25.5 33.625,24.534 33.625,23.34375 C33.625,22.1535 34.5895625,21.1875 35.78125,21.1875 C36.9715,21.1875 37.9375,22.1535 37.9375,23.34375"
            //    },
            //    Width = 4.3125,
            //    Height = 4.3125,
            //    OffsetX = 35.78125,
            //    OffsetY = 23.34375,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes62);
            //NodeGroup NetworkShapes63 = new NodeGroup()
            //{
            //    ID = "Hub",
            //    Children = new string[] {
            //   "Hub1",
            //   "Hub2",
            //   "Hub3",
            //   "Hub4"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes63);
            //Node NetworkShapes64 = new Node()
            //{
            //    ID = "iPhone1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M13 45.6060606 36.0909091 45.6060606 36.0909091 3 13 3"
            //    },
            //    Width = 23.09090805053711,
            //    Height = 42.60606002807617,
            //    OffsetX = 24.545454025268555,
            //    OffsetY = 24.303030014038086,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes64);
            //Node NetworkShapes65 = new Node()
            //{
            //    ID = "iPhone2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M13,38.9332015 L13,37.2424242 L36.0909091,37.2424242 L36.0909091,8.57575758 L13,8.57575758 L13,42.1150196 L13,38.9332015 Z M36.0888122,39.2424242 L36.0888122,45.6060606 L36.0909091,39.2424242 Z M36.0888122,3 L36.0888122,6.57575758 L36.0909091,3 Z M13,47.6060606 C11.8954305,47.6060606 11,46.7106301 11,45.6060606 L11,3 C11,1.8954305 11.8954305,1 13,1 L36.0909091,1 C37.1954786,1 38.0909091,1.8954305 38.0909091,3 L38.0909091,45.6060606 C38.0909091,46.7106301 37.1954786,47.6060606 36.0909091,47.6060606 L13,47.6060606 Z"
            //    },
            //    Width = 27.09090805053711,
            //    Height = 46.60606002807617,
            //    OffsetX = 24.545454025268555,
            //    OffsetY = 24.303030014038086,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes65);
            //Node NetworkShapes66 = new Node()
            //{
            //    ID = "iPhone3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M13,3 L36.0888122,3 L36.0888122,6.58688454 L13,6.58688454 L13,3 Z M13,39.2479573 L36.0888122,39.2479573 L36.0888122,45.5985784 L13,45.5985784 L13,39.2479573 Z"
            //    },
            //    Width = 23.08881378173828,
            //    Height = 42.59857940673828,
            //    OffsetX = 24.54440689086914,
            //    OffsetY = 24.29928970336914,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes66);
            //Node NetworkShapes67 = new Node()
            //{
            //    ID = "iPhone4",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M24.5454545,43.8181818 C25.315306,43.8181818 25.9393939,43.1940939 25.9393939,42.4242424 C25.9393939,41.654391 25.315306,41.030303 24.5454545,41.030303 C23.7756031,41.030303 23.1515152,41.654391 23.1515152,42.4242424 C23.1515152,43.1940939 23.7756031,43.8181818 24.5454545,43.8181818 Z"
            //    },
            //    Width = 2.7878780364990234,
            //    Height = 2.7878761291503906,
            //    OffsetX = 24.54545497894287,
            //    OffsetY = 42.42424201965332,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes67);
            //NodeGroup NetworkShapes68 = new NodeGroup()
            //{
            //    ID = "iPhone",
            //    Children = new string[] {
            //   "iPhone1",
            //   "iPhone2",
            //   "iPhone3",
            //   "iPhone4"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes68);
            //Node NetworkShapes69 = new Node()
            //{
            //    ID = "Laptop1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M4.06666667,32.5333333 L4.06666667,9.1 C4.06666667,8.49248678 4.55915344,8 5.16666667,8 L44.8333333,8 C45.4408466,8 45.9333333,8.49248678 45.9333333,9.1 L45.9333333,32.5333333 L47.9,32.5333333 C48.5075132,32.5333333 49,33.0258201 49,33.6333333 L49,37.6666667 C49,39.3235209 47.6568542,40.6666667 46,40.6666667 L4,40.6666667 C2.34314575,40.6666667 1,39.3235209 1,37.6666667 L1,33.6333333 C1,33.0258201 1.49248678,32.5333333 2.1,32.5333333 L4.06666667,32.5333333 Z"
            //    },
            //    Width = 48,
            //    Height = 32.66666793823242,
            //    OffsetX = 25,
            //    OffsetY = 24.33333396911621,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes69);
            //Node NetworkShapes70 = new Node()
            //{
            //    ID = "Laptop2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M19,34.5333333 L19,34.9856842 C19,35.5300626 19.4413059,35.9713684 19.9856842,35.9713684 L30.2809825,35.9713684 C30.8253608,35.9713684 31.2666667,35.5300626 31.2666667,34.9856842 L31.2666667,34.5333333 L47,34.5333333 L47,37.6666667 C47,38.2189514 46.5522847,38.6666667 46,38.6666667 L4,38.6666667 C3.44771525,38.6666667 3,38.2189514 3,37.6666667 L3,34.5333333 L19,34.5333333 Z M6.06666667,32.5333333 L6.06666667,10 L43.9333333,10 L43.9333333,32.5333333 L6.06666667,32.5333333 Z"
            //    },
            //    Width = 44,
            //    Height = 28.666667938232422,
            //    OffsetX = 25,
            //    OffsetY = 24.33333396911621,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes70);
            //NodeGroup NetworkShapes71 = new NodeGroup()
            //{
            //    ID = "Laptop",
            //    Children = new string[] {
            //   "Laptop1",
            //   "Laptop2"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes71);
            //Node NetworkShapes72 = new Node()
            //{
            //    ID = "Load Balancer1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M40.1570187,33.6875 C40.2214158,33.8196495 40.2575478,33.9681052 40.2575478,34.125 C40.2575478,34.6772847 39.8098326,35.125 39.2575478,35.125 L10.625,35.125 C10.0727153,35.125 9.625,34.6772847 9.625,34.125 C9.625,33.9681052 9.66113207,33.8196495 9.72552911,33.6875 L2.1,33.6875 C1.49248678,33.6875 1,33.1950132 1,32.5875 L1,14.1 C1,13.4924868 1.49248678,13 2.1,13 L47.9,13 C48.5075132,13 49,13.4924868 49,14.1 L49,32.5875 C49,33.1950132 48.5075132,33.6875 47.9,33.6875 L40.1570187,33.6875 Z"
            //    },
            //    Width = 48,
            //    Height = 22.125,
            //    OffsetX = 25,
            //    OffsetY = 24.0625,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes72);
            //Node NetworkShapes73 = new Node()
            //{
            //    ID = "Load Balancer2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M3,31.6875 L3,15 L47,15 L47,31.6875 L3,31.6875 Z M39.375,23.34375 C39.375,22.1535 38.409,21.1875 37.21875,21.1875 C36.0270625,21.1875 35.0625,22.1535 35.0625,23.34375 C35.0625,24.534 36.0270625,25.5 37.21875,25.5 C38.409,25.5 39.375,24.534 39.375,23.34375 Z M45.125,23.34375 C45.125,22.1535 44.159,21.1875 42.96875,21.1875 C41.7770625,21.1875 40.8125,22.1535 40.8125,23.34375 C40.8125,24.534 41.7770625,25.5 42.96875,25.5 C44.159,25.5 45.125,24.534 45.125,23.34375 Z"
            //    },
            //    Width = 44,
            //    Height = 16.6875,
            //    OffsetX = 25,
            //    OffsetY = 23.34375,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes73);
            //Node NetworkShapes74 = new Node()
            //{
            //    ID = "Load Balancer3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M30.75,26.9375 L30.75,28.375 L27.875,28.375 L27.875,26.9375 L26.4375,26.9375 L26.4375,24.0625 L32.1875,24.0625 L32.1875,26.9375 L30.75,26.9375 Z M23.5625,26.9375 L23.5625,28.375 L20.6875,28.375 L20.6875,26.9375 L19.25,26.9375 L19.25,24.0625 L25,24.0625 L25,26.9375 L23.5625,26.9375 Z M30.75,21.1875 L30.75,22.625 L27.875,22.625 L27.875,21.1875 L26.4375,21.1875 L26.4375,18.3125 L32.1875,18.3125 L32.1875,21.1875 L30.75,21.1875 Z M23.5625,21.1875 L23.5625,22.625 L20.6875,22.625 L20.6875,21.1875 L19.25,21.1875 L19.25,18.3125 L25,18.3125 L25,21.1875 L23.5625,21.1875 Z M9.1875,26.9375 L9.1875,28.375 L6.3125,28.375 L6.3125,26.9375 L4.875,26.9375 L4.875,24.0625 L10.625,24.0625 L10.625,26.9375 L9.1875,26.9375 Z M16.375,26.9375 L16.375,28.375 L13.5,28.375 L13.5,26.9375 L12.0625,26.9375 L12.0625,24.0625 L17.8125,24.0625 L17.8125,26.9375 L16.375,26.9375 Z M9.1875,21.1875 L9.1875,22.625 L6.3125,22.625 L6.3125,21.1875 L4.875,21.1875 L4.875,18.3125 L10.625,18.3125 L10.625,21.1875 L9.1875,21.1875 Z M16.375,21.1875 L16.375,22.625 L13.5,22.625 L13.5,21.1875 L12.0625,21.1875 L12.0625,18.3125 L17.8125,18.3125 L17.8125,21.1875 L16.375,21.1875 Z"
            //    },
            //    Width = 27.3125,
            //    Height = 10.0625,
            //    OffsetX = 18.53125,
            //    OffsetY = 23.34375,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes74);
            //Node NetworkShapes75 = new Node()
            //{
            //    ID = "Load Balancer4",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M39.375,23.34375 C39.375,24.534 38.409,25.5 37.21875,25.5 C36.0270625,25.5 35.0625,24.534 35.0625,23.34375 C35.0625,22.1535 36.0270625,21.1875 37.21875,21.1875 C38.409,21.1875 39.375,22.1535 39.375,23.34375"
            //    },
            //    Width = 4.3125,
            //    Height = 4.3125,
            //    OffsetX = 37.21875,
            //    OffsetY = 23.34375,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes75);
            //NodeGroup NetworkShapes76 = new NodeGroup()
            //{
            //    ID = "Load Balancer",
            //    Children = new string[] {
            //   "Load Balancer1",
            //   "Load Balancer2",
            //   "Load Balancer3",
            //   "Load Balancer4"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes76);
            //Node NetworkShapes77 = new Node()
            //{
            //    ID = "Mac1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M20.3466736,44.9464286 L31.2961835,44.9464286 L27.708364,38.7321429 L23.9344931,38.7321429 L20.3466736,44.9464286 Z M18.0372725,44.9464286 L21.625092,38.7321429 L2.1,38.7321429 C1.49248678,38.7321429 1,38.2396561 1,37.6321429 L1,3.5375 C1,2.92998678 1.49248678,2.4375 2.1,2.4375 L47.9,2.4375 C48.5075132,2.4375 49,2.92998678 49,3.5375 L49,37.6321429 C49,38.2396561 48.5075132,38.7321429 47.9,38.7321429 L30.0177651,38.7321429 L33.6055846,44.9464286 L36.5,44.9464286 C37.0522847,44.9464286 37.5,45.3941438 37.5,45.9464286 C37.5,46.4987133 37.0522847,46.9464286 36.5,46.9464286 L15.1428571,46.9464286 C14.5905724,46.9464286 14.1428571,46.4987133 14.1428571,45.9464286 C14.1428571,45.3941438 14.5905724,44.9464286 15.1428571,44.9464286 L18.0372725,44.9464286 Z"
            //    },
            //    Width = 48,
            //    Height = 44.50893020629883,
            //    OffsetX = 25,
            //    OffsetY = 24.691965103149414,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes77);
            //Node NetworkShapes78 = new Node()
            //{
            //    ID = "Mac2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M3,28.875 L47,28.875 L47,36.7321429 L3,36.7321429 L3,28.875 Z M3,26.875 L3,4.4375 L47,4.4375 L47,26.875 L3,26.875 Z M25.71875,35.0625 C26.909614,35.0625 27.875,34.097114 27.875,32.90625 C27.875,31.715386 26.909614,30.75 25.71875,30.75 C24.527886,30.75 23.5625,31.715386 23.5625,32.90625 C23.5625,34.097114 24.527886,35.0625 25.71875,35.0625 Z"
            //    },
            //    Width = 44,
            //    Height = 32.29464340209961,
            //    OffsetX = 25,
            //    OffsetY = 20.584821701049805,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes78);
            //NodeGroup NetworkShapes79 = new NodeGroup()
            //{
            //    ID = "Mac",
            //    Children = new string[] {
            //   "Mac1",
            //   "Mac2"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes79);
            //Node NetworkShapes80 = new Node()
            //{
            //    ID = "Mail Server1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M21.9103512,5.18181818 C24.5972421,2.59290728 28.2503329,1 32.2727273,1 C40.518374,1 47.2121212,7.69376806 47.2121212,15.9393939 C47.2121212,24.1850818 40.5184051,30.8787879 32.2727273,30.8787879 C31.6677361,30.8787879 31.0710996,30.8427539 30.4848485,30.7727168 L30.4848485,38.6363636 C30.4848485,39.7409331 29.589418,40.6363636 28.4848485,40.6363636 L17.9393939,40.6363636 L17.9393939,45.6060606 L29.4848485,45.6060606 C30.0371332,45.6060606 30.4848485,46.0537759 30.4848485,46.6060606 C30.4848485,47.1583454 30.0371332,47.6060606 29.4848485,47.6060606 L4.39393939,47.6060606 C3.84165464,47.6060606 3.39393939,47.1583454 3.39393939,46.6060606 C3.39393939,46.0537759 3.84165464,45.6060606 4.39393939,45.6060606 L15.9393939,45.6060606 L15.9393939,40.6363636 L4,40.6363636 C2.8954305,40.6363636 2,39.7409331 2,38.6363636 L2,29.4848485 C2,29.1205613 2.09739429,28.7790219 2.26756439,28.4848485 C2.09739429,28.1906751 2,27.8491356 2,27.4848485 L2,18.3333333 C2,17.9690462 2.09739429,17.6275067 2.26756439,17.3333333 C2.09739429,17.03916 2,16.6976205 2,16.3333333 L2,7.18181818 C2,6.07724868 2.8954305,5.18181818 4,5.18181818 L21.9103512,5.18181818 Z"
            //    },
            //    Width = 45.212120056152344,
            //    Height = 46.60606002807617,
            //    OffsetX = 24.606060028076172,
            //    OffsetY = 24.303030014038086,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes80);
            //Node NetworkShapes81 = new Node()
            //{
            //    ID = "Mail Server2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M17.5244478,18.3333333 C18.1162301,22.0015899 20.045487,25.2244162 22.7952518,27.4848485 L4,27.4848485 L4,18.3333333 L17.5244478,18.3333333 Z M25.9669964,29.4848485 C26.7700906,29.8596791 27.6119475,30.1651697 28.4848485,30.3936021 L28.4848485,38.6363636 L4,38.6363636 L4,29.4848485 L25.9669964,29.4848485 Z M20.1711666,7.18181818 C18.3861959,9.64307871 17.3333333,12.6691901 17.3333333,15.9393939 C17.3333333,16.0711101 17.3350413,16.2024302 17.3384364,16.3333333 L4,16.3333333 L4,7.18181818 L20.1711666,7.18181818 Z M21.1212121,34.0606061 C21.1212121,33.2911515 20.4967273,32.6666667 19.7272727,32.6666667 C18.9568889,32.6666667 18.3333333,33.2911515 18.3333333,34.0606061 C18.3333333,34.8300606 18.9568889,35.4545455 19.7272727,35.4545455 C20.4967273,35.4545455 21.1212121,34.8300606 21.1212121,34.0606061 Z M25.3030303,34.0606061 C25.3030303,33.2911515 24.6785455,32.6666667 23.9090909,32.6666667 C23.1387071,32.6666667 22.5151515,33.2911515 22.5151515,34.0606061 C22.5151515,34.8300606 23.1387071,35.4545455 23.9090909,35.4545455 C24.6785455,35.4545455 25.3030303,34.8300606 25.3030303,34.0606061 Z"
            //    },
            //    Width = 24.484848022460938,
            //    Height = 31.454545974731445,
            //    OffsetX = 16.24242401123047,
            //    OffsetY = 22.909090995788574,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes81);
            //Node NetworkShapes82 = new Node()
            //{
            //    ID = "Mail Server3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M7.18181818,12.7575758 L7.18181818,10.7575758 L15.5454545,10.7575758 L15.5454545,12.7575758 L7.18181818,12.7575758 Z M7.18181818,23.9090909 L7.18181818,21.9090909 L15.5454545,21.9090909 L15.5454545,23.9090909 L7.18181818,23.9090909 Z M7.18181818,35.0606061 L7.18181818,33.0606061 L15.5454545,33.0606061 L15.5454545,35.0606061 L7.18181818,35.0606061 Z"
            //    },
            //    Width = 8.363636016845703,
            //    Height = 24.30303192138672,
            //    OffsetX = 11.363636016845703,
            //    OffsetY = 22.90909194946289,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes82);
            //Node NetworkShapes83 = new Node()
            //{
            //    ID = "Mail Server4",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M21.1212121,34.0606061 C21.1212121,34.8300606 20.4967273,35.4545455 19.7272727,35.4545455 C18.9568889,35.4545455 18.3333333,34.8300606 18.3333333,34.0606061 C18.3333333,33.2911515 18.9568889,32.6666667 19.7272727,32.6666667 C20.4967273,32.6666667 21.1212121,33.2911515 21.1212121,34.0606061"
            //    },
            //    Width = 2.7878780364990234,
            //    Height = 2.7878761291503906,
            //    OffsetX = 19.727272987365723,
            //    OffsetY = 34.06060600280762,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes83);
            //Node NetworkShapes84 = new Node()
            //{
            //    ID = "Mail Server5",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M25.3030303,34.0606061 C25.3030303,34.8300606 24.6785455,35.4545455 23.9090909,35.4545455 C23.1387071,35.4545455 22.5151515,34.8300606 22.5151515,34.0606061 C22.5151515,33.2911515 23.1387071,32.6666667 23.9090909,32.6666667 C24.6785455,32.6666667 25.3030303,33.2911515 25.3030303,34.0606061"
            //    },
            //    Width = 2.7878780364990234,
            //    Height = 2.7878761291503906,
            //    OffsetX = 23.909090995788574,
            //    OffsetY = 34.06060600280762,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes84);
            //Node NetworkShapes85 = new Node()
            //{
            //    ID = "Mail Server6",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M26.0530303,13.1959361 L32.2921788,17.5520681 L36.9623562,13.9913452 L38.4923928,13.0784402 L38.4923706,13.5578261 L38.4924192,20.7651515 L26.0530303,20.7651515 L26.0530303,13.1959361 Z M27.6873488,12.5075758 L36.5296771,12.5075758 L36.1223618,12.7514389 L32.2536848,15.6957613 L27.6873488,12.5075758 Z M45.2121212,15.9393939 C45.2121212,23.0805116 39.4138363,28.8787879 32.2727273,28.8787879 C25.1316182,28.8787879 19.3333333,23.0805116 19.3333333,15.9393939 C19.3333333,8.79833617 25.1316514,3 32.2727273,3 C39.4138031,3 45.2121212,8.79833617 45.2121212,15.9393939 Z M24.5530303,22.2651515 L39.9924466,22.2651515 L39.9923706,13.5578434 L39.9924242,11.7575981 L39.9924466,11.0075758 L24.5530303,11.0075758 L24.5530303,22.2651515 Z"
            //    },
            //    Width = 25.878786087036133,
            //    Height = 25.878787994384766,
            //    OffsetX = 32.27272701263428,
            //    OffsetY = 15.939393997192383,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes85);
            //NodeGroup NetworkShapes86 = new NodeGroup()
            //{
            //    ID = "Mail Server",
            //    Children = new string[] {
            //   "Mail Server1",
            //   "Mail Server2",
            //   "Mail Server3",
            //   "Mail Server4",
            //   "Mail Server5",
            //   "Mail Server6"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes86);
            //Node NetworkShapes87 = new Node()
            //{
            //    ID = "Main Frame1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M32.6666667,43.4 L32.6666667,41.3333333 L36.2666667,41.3333333 L36.2666667,37.5918294 L29.0666667,37.5918294 C27.9620972,37.5918294 27.0666667,36.6963989 27.0666667,35.5918294 L27.0666667,4 C27.0666667,2.8954305 27.9620972,2 29.0666667,2 L45.4666667,2 C46.5712362,2 47.4666667,2.8954305 47.4666667,4 L47.4666667,35.5918294 C47.4666667,36.6963989 46.5712362,37.5918294 45.4666667,37.5918294 L38.2666667,37.5918294 L38.2666667,41.3333333 L41.8666667,41.3333333 L41.8666667,43.4 L48,43.4 L48,45.4 L41.8666667,45.4 L41.8666667,47.4666667 L32.6666667,47.4666667 L32.6666667,45.4 L17.3333333,45.4 L17.3333333,47.4666667 L8.13333333,47.4666667 L8.13333333,45.4 L2,45.4 L2,43.4 L8.13333333,43.4 L8.13333333,41.3333333 L11.7333333,41.3333333 L11.7333333,37.5918294 L4.53333333,37.5918294 C3.42876383,37.5918294 2.53333333,36.6963989 2.53333333,35.5918294 L2.53333333,4 C2.53333333,2.8954305 3.42876383,2 4.53333333,2 L20.9333333,2 C22.0379028,2 22.9333333,2.8954305 22.9333333,4 L22.9333333,35.5918294 C22.9333333,36.6963989 22.0379028,37.5918294 20.9333333,37.5918294 L13.7333333,37.5918294 L13.7333333,41.3333333 L17.3333333,41.3333333 L17.3333333,43.4 L32.6666667,43.4 Z"
            //    },
            //    Width = 46,
            //    Height = 45.46666717529297,
            //    OffsetX = 25,
            //    OffsetY = 24.733333587646484,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes87);
            //Node NetworkShapes88 = new Node()
            //{
            //    ID = "Main Frame2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M8.13333333,30.0666667 L8.13333333,28.0666667 L17.3333333,28.0666667 L17.3333333,30.0666667 L8.13333333,30.0666667 Z M8.13333333,23.9333333 L8.13333333,21.9333333 L17.3333333,21.9333333 L17.3333333,23.9333333 L8.13333333,23.9333333 Z M8.13333333,17.8 L8.13333333,15.8 L17.3333333,15.8 L17.3333333,17.8 L8.13333333,17.8 Z M8.13333333,11.6666667 L8.13333333,9.66666667 L17.3333333,9.66666667 L17.3333333,11.6666667 L8.13333333,11.6666667 Z M32.6666667,30.0666667 L32.6666667,28.0666667 L41.8666667,28.0666667 L41.8666667,30.0666667 L32.6666667,30.0666667 Z M32.6666667,23.9333333 L32.6666667,21.9333333 L41.8666667,21.9333333 L41.8666667,23.9333333 L32.6666667,23.9333333 Z M32.6666667,17.8 L32.6666667,15.8 L41.8666667,15.8 L41.8666667,17.8 L32.6666667,17.8 Z M32.6666667,11.6666667 L32.6666667,9.66666667 L41.8666667,9.66666667 L41.8666667,11.6666667 L32.6666667,11.6666667 Z"
            //    },
            //    Width = 33.73332977294922,
            //    Height = 20.400001525878906,
            //    OffsetX = 24.999998092651367,
            //    OffsetY = 19.86666774749756,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes88);
            //Node NetworkShapes89 = new Node()
            //{
            //    ID = "Main Frame3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M20.9333333,35.5918294 L4.53333333,35.5918294 L4.53333333,4 L20.9333333,4 L20.9333333,35.5918294 Z M45.4666667,35.5918294 L29.0666667,35.5918294 L29.0666667,4 L45.4666667,4 L45.4666667,35.5918294 Z"
            //    },
            //    Width = 40.93333435058594,
            //    Height = 31.59183120727539,
            //    OffsetX = 25.000000476837158,
            //    OffsetY = 19.795915603637695,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes89);
            //NodeGroup NetworkShapes90 = new NodeGroup()
            //{
            //    ID = "Main Frame",
            //    Children = new string[] {
            //   "Main Frame1",
            //   "Main Frame2",
            //   "Main Frame3"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes90);
            //Node NetworkShapes91 = new Node()
            //{
            //    ID = "Male User1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M2.07722814,49 L2.00711847,48.0756286 C1.98028261,47.4228088 2.06071157,46.640764 2.32682198,45.7234637 C2.73305433,44.3231536 3.4904177,42.9410618 4.67548756,41.6609141 C5.21719735,41.0757431 5.83975013,40.522807 6.54697063,40.0067862 C7.77078518,39.1139126 9.19162304,38.4403261 10.793006,37.9555789 C12.7020583,37.3786038 13.2075323,37.2171433 14.194478,36.8354663 C15.9138722,36.1705329 17.1619402,35.4555687 17.8124947,34.7165274 L17.8124947,29.8263435 C16.9945352,29.1573589 16.3810512,28.1638756 15.919772,26.9357254 C15.6396972,26.1900298 15.4332599,25.4008608 15.2870567,24.6130778 C15.2438622,24.380334 15.2100712,24.1718947 15.1844569,23.9933901 C14.9570648,23.8106636 14.7507274,23.6222391 14.5651412,23.4281418 C13.0070066,21.7985499 13.0140858,19.9683808 13.9527843,18.3507452 C14.0413273,18.1981613 14.1304263,18.0605155 14.2165521,17.9385483 C12.5538036,11.41237 13.334146,6.91143888 15.7423339,4.13006465 C16.6782996,3.0490564 17.6373151,2.46428697 18.2848864,2.24736457 C22.7631049,0.474753925 26.4055063,0.687627081 29.1632984,2.1537352 C29.8082518,2.4966078 30.2940389,2.84764988 30.6252759,3.14536962 C34.2739043,3.8922192 35.8824904,6.83037381 35.909056,11.0218668 C35.9194693,12.6648574 35.6877321,14.4055396 35.2959492,16.1404476 C35.1624554,16.7315905 35.0193457,17.2802987 34.8758705,17.773587 C36.3757341,19.9331625 36.0029966,21.9623839 34.4664815,23.5956287 C34.17593,23.9044717 33.8861289,24.157227 33.6270593,24.3532197 C33.4668325,25.7980329 33.0193816,27.0924369 32.3700286,28.226637 C32.0028621,28.8679527 31.6305114,29.3663732 31.3125331,29.7198752 L31.3125331,34.7166449 C31.9628122,35.455631 33.2109512,36.1706219 34.9306647,36.8355979 C35.9175109,37.2171899 36.4213687,37.37812 38.3324376,37.9557047 C39.9334047,38.4403261 41.3542426,39.1139126 42.5780908,40.0068108 C43.2852776,40.522807 43.9078304,41.0757431 44.4495402,41.6609141 C45.6346101,42.9410618 46.3919734,44.3231536 46.7982058,45.7234637 C47.0643162,46.640764 47.1447452,47.4228088 47.1221289,47.9981924 C47.1204972,48.0333393 47.0957208,48.3672752 47.0477996,49 L2.07722814,49 Z"
            //    },
            //    Width = 45.12351989746094,
            //    Height = 48.014381408691406,
            //    OffsetX = 24.563986778259277,
            //    OffsetY = 24.992810010910034,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes91);
            //Node NetworkShapes92 = new Node()
            //{
            //    ID = "Male User2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M44.8773998,46.2806928 C44.5554471,45.1709004 43.949108,44.0644086 42.9818748,43.0195746 C42.5283271,42.5296389 42.0025672,42.0626718 41.3992743,41.6224814 C40.3687461,40.8706262 39.1497728,40.292739 37.7534084,39.8700518 C35.7888164,39.2762909 35.2619457,39.1080106 34.2093554,38.7009967 C31.9691109,37.8347427 30.3653667,36.8716174 29.4955088,35.6390629 L29.3125331,35.3797934 L29.3125331,28.871682 L29.6378685,28.5743171 C29.680832,28.5350474 29.7804556,28.4321389 29.9183062,28.2678801 C30.16022,27.9796226 30.4048318,27.6338376 30.6343595,27.2329305 C31.2115759,26.2247286 31.589646,25.0563621 31.6742292,23.7315822 L31.7077493,23.206574 L32.159388,22.9367968 C32.3528513,22.8212353 32.6823106,22.5733047 33.0097893,22.2252099 C34.0116723,21.1602543 34.1612296,20.0930657 32.9807734,18.7510188 L32.59868,18.3166212 L32.7848015,17.7688481 C32.816995,17.6740999 32.8769454,17.4849408 32.9554519,17.2150242 C33.0880112,16.7592665 33.220936,16.2496085 33.3450743,15.6998944 C33.7059114,14.1020215 33.9184208,12.5057683 33.9090962,11.0345426 C33.8872369,7.58560855 32.7039706,5.50894968 29.9823523,5.06013018 L29.6419462,5.00399414 L29.4085703,4.74990118 C29.2431132,4.56975627 28.8488459,4.25162448 28.2244731,3.91969302 C25.9826661,2.72789491 22.9524232,2.55079819 18.9724188,4.12476304 C18.905151,4.1474429 18.7366978,4.22391845 18.5002308,4.36810659 C18.0806411,4.62395569 17.6554062,4.97598312 17.2543405,5.43920023 C15.2556414,7.74762898 14.6090406,11.7199813 16.2770285,17.9116634 L16.4244961,18.4590728 L16.0305143,18.8667272 C15.9593097,18.9404029 15.8228465,19.1129233 15.6826286,19.3545573 C15.1506117,20.2713688 15.1472404,21.1429256 16.0106931,22.045977 C16.2003124,22.2442924 16.4309564,22.4416485 16.7053762,22.636819 L17.0802216,22.9034132 L17.1217203,23.3615173 C17.1368143,23.5281402 17.1778303,23.8405185 17.2534787,24.2481333 C17.3797754,24.9286549 17.5574293,25.6077905 17.7920678,26.2325125 C18.1968312,27.3101903 18.7224765,28.0877282 19.3316555,28.457765 L19.8124947,28.7498437 L19.8124947,35.3799243 L19.6293819,35.6392571 C18.7592331,36.8716017 17.1556079,37.8346696 14.9158638,38.7008356 C13.8631563,39.1079443 13.3345986,39.2767783 11.3720353,39.869926 C9.97525493,40.292739 8.75628163,40.8706262 7.72578714,41.6224568 C7.12246059,42.0626718 6.59670066,42.5296389 6.14315297,43.0195746 C5.17591979,44.0644086 4.56958067,45.1709004 4.24762798,46.2806928 C4.17264398,46.5391677 4.11740257,46.7801368 4.07831521,47 L45.0467126,47 C45.0076252,46.7801368 44.9523838,46.5391677 44.8773998,46.2806928 Z"
            //    },
            //    Width = 40.9683952331543,
            //    Height = 44.01496124267578,
            //    OffsetX = 24.56251287460327,
            //    OffsetY = 24.992520809173584,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes92);
            //NodeGroup NetworkShapes93 = new NodeGroup()
            //{
            //    ID = "Male User",
            //    Children = new string[] {
            //   "Male User1",
            //   "Male User2"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes93);
            //Node NetworkShapes94 = new Node()
            //{
            //    ID = "Modem1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M6.75,33.6875 L2.1,33.6875 C1.49248678,33.6875 1,33.1950132 1,32.5875 L1,15.5375 C1,14.9299868 1.49248678,14.4375 2.1,14.4375 L47.9,14.4375 C48.5075132,14.4375 49,14.9299868 49,15.5375 L49,32.5875 C49,33.1950132 48.5075132,33.6875 47.9,33.6875 L43.25,33.6875 L43.25,35.5525 C43.0239038,36.3364038 43.0239038,36.3364038 42.24,36.5625 L35.0725,36.5625 C34.2885962,36.3364038 34.2885962,36.3364038 34.0625,35.5525 L34.0625,33.6875 L15.9375,33.6875 L15.9375,35.5525 C15.7114038,36.3364038 15.7114038,36.3364038 14.9275,36.5625 L7.76,36.5625 C6.9760962,36.3364038 6.9760962,36.3364038 6.75,35.5525 L6.75,33.6875 Z M8.75,33.6875 L8.75,34.5625 L13.9375,34.5625 L13.9375,33.6875 L8.75,33.6875 Z M36.0625,33.6875 L36.0625,34.5625 L41.25,34.5625 L41.25,33.6875 L36.0625,33.6875 Z"
            //    },
            //    Width = 48,
            //    Height = 22.125,
            //    OffsetX = 25,
            //    OffsetY = 25.5,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes94);
            //Node NetworkShapes95 = new Node()
            //{
            //    ID = "Modem2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M3,31.6875 L3,16.4375 L47,16.4375 L47,31.6875 L3,31.6875 Z M9.1875,24.0625 C9.1875,23.269 8.5435,22.625 7.75,22.625 C6.95554167,22.625 6.3125,23.269 6.3125,24.0625 C6.3125,24.856 6.95554167,25.5 7.75,25.5 C8.5435,25.5 9.1875,24.856 9.1875,24.0625 Z M43.6875,24.0625 C43.6875,23.269 43.0435,22.625 42.25,22.625 C41.4555417,22.625 40.8125,23.269 40.8125,24.0625 C40.8125,24.856 41.4555417,25.5 42.25,25.5 C43.0435,25.5 43.6875,24.856 43.6875,24.0625 Z M35.0625,24.0625 C35.0625,23.269 34.4185,22.625 33.625,22.625 C32.8305417,22.625 32.1875,23.269 32.1875,24.0625 C32.1875,24.856 32.8305417,25.5 33.625,25.5 C34.4185,25.5 35.0625,24.856 35.0625,24.0625 Z M39.375,24.0625 C39.375,23.269 38.731,22.625 37.9375,22.625 C37.1430417,22.625 36.5,23.269 36.5,24.0625 C36.5,24.856 37.1430417,25.5 37.9375,25.5 C38.731,25.5 39.375,24.856 39.375,24.0625 Z"
            //    },
            //    Width = 44,
            //    Height = 15.25,
            //    OffsetX = 25,
            //    OffsetY = 24.0625,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes95);
            //Node NetworkShapes96 = new Node()
            //{
            //    ID = "Modem3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M12.0625 25.0625 12.0625 23.0625 27.875 23.0625 27.875 25.0625"
            //    },
            //    Width = 15.8125,
            //    Height = 2,
            //    OffsetX = 19.96875,
            //    OffsetY = 24.0625,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes96);
            //Node NetworkShapes97 = new Node()
            //{
            //    ID = "Modem4",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M35.0625,24.0625 C35.0625,24.856 34.4185,25.5 33.625,25.5 C32.8305417,25.5 32.1875,24.856 32.1875,24.0625 C32.1875,23.269 32.8305417,22.625 33.625,22.625 C34.4185,22.625 35.0625,23.269 35.0625,24.0625"
            //    },
            //    Width = 2.875,
            //    Height = 2.875,
            //    OffsetX = 33.625,
            //    OffsetY = 24.0625,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes97);
            //Node NetworkShapes98 = new Node()
            //{
            //    ID = "Modem5",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M39.375,24.0625 C39.375,24.856 38.731,25.5 37.9375,25.5 C37.1430417,25.5 36.5,24.856 36.5,24.0625 C36.5,23.269 37.1430417,22.625 37.9375,22.625 C38.731,22.625 39.375,23.269 39.375,24.0625"
            //    },
            //    Width = 2.875,
            //    Height = 2.875,
            //    OffsetX = 37.9375,
            //    OffsetY = 24.0625,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes98);
            //NodeGroup NetworkShapes99 = new NodeGroup()
            //{
            //    ID = "Modem",
            //    Children = new string[] {
            //   "Modem1",
            //   "Modem2",
            //   "Modem3",
            //   "Modem4",
            //   "Modem5"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes99);
            //Node NetworkShapes100 = new Node()
            //{
            //    ID = "Mointor1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M21.0714286,41.7857143 L27.2857143,41.7857143 L27.2857143,35.5714286 L21.0714286,35.5714286 L21.0714286,41.7857143 Z M19.0714286,41.7857143 L19.0714286,35.5714286 L2.1,35.5714286 C1.49248678,35.5714286 1,35.0789418 1,34.4714286 L1,5.1 C1,4.49248678 1.49248678,4 2.1,4 L47.9,4 C48.5075132,4 49,4.49248678 49,5.1 L49,34.4714286 C49,35.0789418 48.5075132,35.5714286 47.9,35.5714286 L29.2857143,35.5714286 L29.2857143,41.7857143 L33.2142857,41.7857143 C33.7665705,41.7857143 34.2142857,42.2334295 34.2142857,42.7857143 C34.2142857,43.337999 33.7665705,43.7857143 33.2142857,43.7857143 L15.1428571,43.7857143 C14.5905724,43.7857143 14.1428571,43.337999 14.1428571,42.7857143 C14.1428571,42.2334295 14.5905724,41.7857143 15.1428571,41.7857143 L19.0714286,41.7857143 Z"
            //    },
            //    Width = 48,
            //    Height = 39.78571319580078,
            //    OffsetX = 25,
            //    OffsetY = 23.89285659790039,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes100);
            //Node NetworkShapes101 = new Node()
            //{
            //    ID = "Mointor2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M3 33.5714286 47 33.5714286 47 6 3 6"
            //    },
            //    Width = 44,
            //    Height = 27.571430206298828,
            //    OffsetX = 25,
            //    OffsetY = 19.785715103149414,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes101);
            //NodeGroup NetworkShapes102 = new NodeGroup()
            //{
            //    ID = "Mointor",
            //    Children = new string[] {
            //   "Mointor1",
            //   "Mointor2"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes102);
            //Node NetworkShapes103 = new Node()
            //{
            //    ID = "Multiserver1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M6.06666667,9 L43.9333333,9 L47.2233333,9 C48.0072371,9.2260962 48.0072371,9.2260962 48.2333333,10.01 L48.2333333,14.59 C48.0072371,15.3739038 48.0072371,15.3739038 47.2233333,15.6 L45.9333333,15.6 L45.9333333,30.4666667 L47.2233333,30.4666667 C48.0072371,30.6927629 48.0072371,30.6927629 48.2333333,31.4766667 L48.2333333,36.0566667 C48.0072371,36.8405705 48.0072371,36.8405705 47.2233333,37.0666667 L43.9333333,37.0666667 L6.06666667,37.0666667 L2.77666667,37.0666667 C1.99276287,36.8405705 1.99276287,36.8405705 1.76666667,36.0566667 L1.76666667,31.4766667 C1.99276287,30.6927629 1.99276287,30.6927629 2.77666667,30.4666667 L4.06666667,30.4666667 L4.06666667,15.6 L2.77666667,15.6 C1.99276287,15.3739038 1.99276287,15.3739038 1.76666667,14.59 L1.76666667,10.01 C1.99276287,9.2260962 1.99276287,9.2260962 2.77666667,9 L6.06666655,9 Z"
            //    },
            //    Width = 46.46666717529297,
            //    Height = 28.066665649414062,
            //    OffsetX = 25.00000023841858,
            //    OffsetY = 23.03333282470703,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes103);
            //Node NetworkShapes104 = new Node()
            //{
            //    ID = "Multiserver2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M6.06666667,35.0666667 L6.06666667,11 L43.9333333,11 L43.9333333,35.0666667 L6.06666667,35.0666667 Z M12.7333333,29.9333333 C12.7333333,29.0869333 12.0464,28.4 11.2,28.4 C10.3525778,28.4 9.66666667,29.0869333 9.66666667,29.9333333 C9.66666667,30.7797333 10.3525778,31.4666667 11.2,31.4666667 C12.0464,31.4666667 12.7333333,30.7797333 12.7333333,29.9333333 Z M31.1333333,29.9333333 C31.1333333,29.0869333 30.4464,28.4 29.6,28.4 C28.7525778,28.4 28.0666667,29.0869333 28.0666667,29.9333333 C28.0666667,30.7797333 28.7525778,31.4666667 29.6,31.4666667 C30.4464,31.4666667 31.1333333,30.7797333 31.1333333,29.9333333 Z M17.3333333,29.9333333 C17.3333333,29.0869333 16.6464,28.4 15.8,28.4 C14.9525778,28.4 14.2666667,29.0869333 14.2666667,29.9333333 C14.2666667,30.7797333 14.9525778,31.4666667 15.8,31.4666667 C16.6464,31.4666667 17.3333333,30.7797333 17.3333333,29.9333333 Z M35.7333333,29.9333333 C35.7333333,29.0869333 35.0464,28.4 34.2,28.4 C33.3525778,28.4 32.6666667,29.0869333 32.6666667,29.9333333 C32.6666667,30.7797333 33.3525778,31.4666667 34.2,31.4666667 C35.0464,31.4666667 35.7333333,30.7797333 35.7333333,29.9333333 Z M20.4,31.4666667 C21.2464,31.4666667 21.9333333,30.7797333 21.9333333,29.9333333 C21.9333333,29.0869333 21.2464,28.4 20.4,28.4 C19.5525778,28.4 18.8666667,29.0869333 18.8666667,29.9333333 C18.8666667,30.7797333 19.5525778,31.4666667 20.4,31.4666667 Z M38.8,31.4666667 C39.6464,31.4666667 40.3333333,30.7797333 40.3333333,29.9333333 C40.3333333,29.0869333 39.6464,28.4 38.8,28.4 C37.9525778,28.4 37.2666667,29.0869333 37.2666667,29.9333333 C37.2666667,30.7797333 37.9525778,31.4666667 38.8,31.4666667 Z"
            //    },
            //    Width = 37.866668701171875,
            //    Height = 24.066665649414062,
            //    OffsetX = 25.000000953674316,
            //    OffsetY = 23.03333282470703,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes104);
            //Node NetworkShapes105 = new Node()
            //{
            //    ID = "Multiserver3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M12.7333333,29.9333333 C12.7333333,30.7797333 12.0464,31.4666667 11.2,31.4666667 C10.3525778,31.4666667 9.66666667,30.7797333 9.66666667,29.9333333 C9.66666667,29.0869333 10.3525778,28.4 11.2,28.4 C12.0464,28.4 12.7333333,29.0869333 12.7333333,29.9333333"
            //    },
            //    Width = 3.066666603088379,
            //    Height = 3.0666675567626953,
            //    OffsetX = 11.200000286102295,
            //    OffsetY = 29.93333339691162,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes105);
            //Node NetworkShapes106 = new Node()
            //{
            //    ID = "Multiserver4",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M31.1333333,29.9333333 C31.1333333,30.7797333 30.4464,31.4666667 29.6,31.4666667 C28.7525778,31.4666667 28.0666667,30.7797333 28.0666667,29.9333333 C28.0666667,29.0869333 28.7525778,28.4 29.6,28.4 C30.4464,28.4 31.1333333,29.0869333 31.1333333,29.9333333"
            //    },
            //    Width = 3.0666656494140625,
            //    Height = 3.0666675567626953,
            //    OffsetX = 29.600000381469727,
            //    OffsetY = 29.93333339691162,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes106);
            //Node NetworkShapes107 = new Node()
            //{
            //    ID = "Multiserver5",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M17.3333333,29.9333333 C17.3333333,30.7797333 16.6464,31.4666667 15.8,31.4666667 C14.9525778,31.4666667 14.2666667,30.7797333 14.2666667,29.9333333 C14.2666667,29.0869333 14.9525778,28.4 15.8,28.4 C16.6464,28.4 17.3333333,29.0869333 17.3333333,29.9333333"
            //    },
            //    Width = 3.0666675567626953,
            //    Height = 3.0666675567626953,
            //    OffsetX = 15.800000190734863,
            //    OffsetY = 29.93333339691162,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes107);
            //Node NetworkShapes108 = new Node()
            //{
            //    ID = "Multiserver6",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M35.7333333,29.9333333 C35.7333333,30.7797333 35.0464,31.4666667 34.2,31.4666667 C33.3525778,31.4666667 32.6666667,30.7797333 32.6666667,29.9333333 C32.6666667,29.0869333 33.3525778,28.4 34.2,28.4 C35.0464,28.4 35.7333333,29.0869333 35.7333333,29.9333333"
            //    },
            //    Width = 3.0666656494140625,
            //    Height = 3.0666675567626953,
            //    OffsetX = 34.20000076293945,
            //    OffsetY = 29.93333339691162,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes108);
            //Node NetworkShapes109 = new Node()
            //{
            //    ID = "Multiserver7",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M10.2,17.6666667 L12.2,17.6666667 L12.2,26.8666667 L10.2,26.8666667 L10.2,17.6666667 Z M37.8,17.6666667 L39.8,17.6666667 L39.8,26.8666667 L37.8,26.8666667 L37.8,17.6666667 Z M24,17.6666667 L26,17.6666667 L26,26.8666667 L24,26.8666667 L24,17.6666667 Z M17.6132894,17.6666667 L18.6132894,17.6666667 L18.6132894,26.8666667 L17.6132894,26.8666667 L17.6132894,17.6666667 Z M20.6410238,17.6666667 L21.6410238,17.6666667 L21.6410238,26.8666667 L20.6410238,26.8666667 L20.6410238,17.6666667 Z M14.5922933,17.6470133 L15.5922933,17.6470133 L15.5922933,26.8470133 L14.5922933,26.8470133 L14.5922933,17.6470133 Z M31.4132894,17.6666667 L32.4132894,17.6666667 L32.4132894,26.8666667 L31.4132894,26.8666667 L31.4132894,17.6666667 Z M28.3466227,17.6666667 L29.3466227,17.6666667 L29.3466227,26.8666667 L28.3466227,26.8666667 L28.3466227,17.6666667 Z M34.4410238,17.6666667 L35.4410238,17.6666667 L35.4410238,26.8666667 L34.4410238,26.8666667 L34.4410238,17.6666667 Z M25,31.4666667 C24.1525778,31.4666667 23.4666667,30.7797333 23.4666667,29.9333333 C23.4666667,29.0869333 24.1525778,28.4 25,28.4 C25.8464,28.4 26.5333333,29.0869333 26.5333333,29.9333333 C26.5333333,30.7797333 25.8464,31.4666667 25,31.4666667 Z M25,16.1333333 C24.1525778,16.1333333 23.4666667,15.4464 23.4666667,14.6 C23.4666667,13.7536 24.1525778,13.0666667 25,13.0666667 C25.8464,13.0666667 26.5333333,13.7536 26.5333333,14.6 C26.5333333,15.4464 25.8464,16.1333333 25,16.1333333 Z"
            //    },
            //    Width = 29.599998474121094,
            //    Height = 18.400001525878906,
            //    OffsetX = 24.999999046325684,
            //    OffsetY = 22.266667366027832,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes109);
            //NodeGroup NetworkShapes110 = new NodeGroup()
            //{
            //    ID = "Multiserver",
            //    Children = new string[] {
            //               "Multiserver1",
            //               "Multiserver2",
            //               "Multiserver3",
            //               "Multiserver4",
            //               "Multiserver5",
            //               "Multiserver6",
            //               "Multiserver7"
            //        }
            //};
            //NetworkShapesList.Add(NetworkShapes110);
            //Node NetworkShapes112 = new Node()
            //{
            //    ID = "NAS Filter1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M32.6666667,36.5955157 C32.6996029,36.5984837 32.7329577,36.6 32.7666667,36.6 L41.7666667,36.6 C42.3741799,36.6 42.8666667,36.1075132 42.8666667,35.5 L42.8666667,14.2333333 C42.8666667,13.6258201 42.3741799,13.1333333 41.7666667,13.1333333 L32.7666667,13.1333333 C32.7329577,13.1333333 32.6996029,13.1348496 32.6666667,13.1378176 C32.6337305,13.1348496 32.6003756,13.1333333 32.5666667,13.1333333 L23.5666667,13.1333333 C23.5329577,13.1333333 23.4996029,13.1348496 23.4666667,13.1378176 C23.4337305,13.1348496 23.4003756,13.1333333 23.3666667,13.1333333 L14.3666667,13.1333333 C13.7591534,13.1333333 13.2666667,13.6258201 13.2666667,14.2333333 L13.2666667,35.5 C13.2666667,36.1075132 13.7591534,36.6 14.3666667,36.6 L23.3666667,36.6 C23.4003756,36.6 23.4337305,36.5984837 23.4666667,36.5955157 C23.4996029,36.5984837 23.5329577,36.6 23.5666667,36.6 L32.5666667,36.6 C32.6003756,36.6 32.6337305,36.5984837 32.6666667,36.5955157 Z M3,40.7333333 L3,9 L47,9 L47,40.7333333 L3,40.7333333 Z M8.13333333,18.7333333 C8.97973333,18.7333333 9.66666667,18.0464 9.66666667,17.2 C9.66666667,16.3536 8.97973333,15.6666667 8.13333333,15.6666667 C7.28591111,15.6666667 6.6,16.3536 6.6,17.2 C6.6,18.0464 7.28591111,18.7333333 8.13333333,18.7333333 Z M8.13333333,23.3333333 C8.97973333,23.3333333 9.66666667,22.6464 9.66666667,21.8 C9.66666667,20.9536 8.97973333,20.2666667 8.13333333,20.2666667 C7.28591111,20.2666667 6.6,20.9536 6.6,21.8 C6.6,22.6464 7.28591111,23.3333333 8.13333333,23.3333333 Z"
            //    },
            //    Width = 44,
            //    Height = 31.733333587646484,
            //    OffsetX = 25,
            //    OffsetY = 24.866666793823242,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes112);
            //Node NetworkShapes113 = new Node()
            //{
            //    ID = "NAS Filter2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M8.13333333,23.3333333 C7.28591111,23.3333333 6.6,22.6464 6.6,21.8 C6.6,20.9536 7.28591111,20.2666667 8.13333333,20.2666667 C8.97973333,20.2666667 9.66666667,20.9536 9.66666667,21.8 C9.66666667,22.6464 8.97973333,23.3333333 8.13333333,23.3333333 Z"
            //    },
            //    Width = 3.066667079925537,
            //    Height = 3.0666675567626953,
            //    OffsetX = 8.133333444595337,
            //    OffsetY = 21.800000190734863,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes113);
            //Node NetworkShapes114 = new Node()
            //{
            //    ID = "NAS Filter3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M22.4666667,34.6 L15.2666667,34.6 L15.2666667,15.1333333 L22.4666667,15.1333333 L22.4666667,34.6 Z M18.8666667,20.2666667 C19.7130667,20.2666667 20.4,19.5797333 20.4,18.7333333 C20.4,17.8869333 19.7130667,17.2 18.8666667,17.2 C18.0192444,17.2 17.3333333,17.8869333 17.3333333,18.7333333 C17.3333333,19.5797333 18.0192444,20.2666667 18.8666667,20.2666667 Z"
            //    },
            //    Width = 7.200000762939453,
            //    Height = 19.466665267944336,
            //    OffsetX = 18.866666793823242,
            //    OffsetY = 24.866665840148926,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes114);
            //Node NetworkShapes115 = new Node()
            //{
            //    ID = "NAS Filter4",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M31.6666667,34.6 L24.4666667,34.6 L24.4666667,15.1333333 L31.6666667,15.1333333 L31.6666667,34.6 Z M28.0666667,20.2666667 C28.9130667,20.2666667 29.6,19.5797333 29.6,18.7333333 C29.6,17.8869333 28.9130667,17.2 28.0666667,17.2 C27.2192444,17.2 26.5333333,17.8869333 26.5333333,18.7333333 C26.5333333,19.5797333 27.2192444,20.2666667 28.0666667,20.2666667 Z"
            //    },
            //    Width = 7.19999885559082,
            //    Height = 19.466665267944336,
            //    OffsetX = 28.06666660308838,
            //    OffsetY = 24.866665840148926,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes115);
            //Node NetworkShapes116 = new Node()
            //{
            //    ID = "NAS Filter5",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M40.8666667,34.6 L33.6666667,34.6 L33.6666667,15.1333333 L40.8666667,15.1333333 L40.8666667,34.6 Z M37.2666667,20.2666667 C38.1130667,20.2666667 38.8,19.5797333 38.8,18.7333333 C38.8,17.8869333 38.1130667,17.2 37.2666667,17.2 C36.4192444,17.2 35.7333333,17.8869333 35.7333333,18.7333333 C35.7333333,19.5797333 36.4192444,20.2666667 37.2666667,20.2666667 Z"
            //    },
            //    Width = 7.1999969482421875,
            //    Height = 19.466665267944336,
            //    OffsetX = 37.266666412353516,
            //    OffsetY = 24.866665840148926,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes116);
            //Node NetworkShapes117 = new Node()
            //{
            //    ID = "NAS Filter6",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M17.3333333,21.8 L20.4,21.8 L20.4,29.4666667 L17.3333333,29.4666667 L17.3333333,21.8 Z M26.5333333,21.8 L29.6,21.8 L29.6,29.4666667 L26.5333333,29.4666667 L26.5333333,21.8 Z M35.7333333,21.8 L38.8,21.8 L38.8,29.4666667 L35.7333333,29.4666667 L35.7333333,21.8 Z"
            //    },
            //    Width = 21.466665267944336,
            //    Height = 7.666667938232422,
            //    OffsetX = 28.06666660308838,
            //    OffsetY = 25.633333206176758,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes117);
            //NodeGroup NetworkShapes118 = new NodeGroup()
            //{
            //    ID = "NAS Filter",
            //    Children = new string[] {
            //   "NAS Filter1",
            //   "NAS Filter2",
            //   "NAS Filter3",
            //   "NAS Filter4",
            //   "NAS Filter5",
            //   "NAS Filter6"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes118);
            //Node networkshapes119 = new Node()
            //{
            //    ID = "network cloud1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "m49,30.4834375 c49,35.9298943 44.5049104,40.337 38.9710625,40.337 l11.0289375,40.337 c5.49508961,40.337 1,35.9298943 1,30.4834375 c1,25.9318067 4.16001026,22.0415234 8.52583225,20.9422431 c8.52452885,20.88976 8.523875,20.8372256 8.523875,20.784625 c8.523875,17.1302733 11.5388004,14.1755 15.2465625,14.1755 c16.4209699,14.1755 17.5512918,14.4734152 18.54299,15.023593 c20.9535524,10.2029491 23.8492135,8 29.390125,8 c37.0944718,8 41.8053648,13.5840524 41.8096221,21.031832 c46.0131143,22.2472688 49,26.0607369 49,30.4834375 z"
            //    },
            //    Width = 48,
            //    Height = 32.33700180053711,
            //    OffsetX = 25,
            //    OffsetY = 24.168500900268555,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(networkshapes119);
            //Node networkshapes120 = new Node()
            //{
            //    ID = "network cloud2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "m47,30.4834375 c47,26.7392959 44.2976876,23.5324414 40.5861964,22.7901432 l39.7248783,22.6178796 l39.7846288,21.7415386 c39.8011159,21.499728 39.809625,21.2663821 39.809625,21.0419375 c39.809625,14.6252262 35.9105144,10 29.390125,10 c24.3745197,10 22.0853351,11.9955667 19.8562326,16.9190699 l19.3137207,18.1173365 l18.3041933,17.2741185 c17.4609124,16.5697596 16.3861372,16.1755 15.2465625,16.1755 c12.6344489,16.1755 10.523875,18.2439649 10.523875,20.784625 c10.523875,21.0449111 10.5472838,21.304456 10.5936987,21.5695096 l10.7696575,22.5743268 l9.76153676,22.7302495 c5.88619787,23.3296353 3,26.6118959 3,30.4834375 c3,34.8163792 6.5909069,38.337 11.0289375,38.337 l38.9710625,38.337 c43.4090931,38.337 47,34.8163792 47,30.4834375 z"
            //    },
            //    Width = 44,
            //    Height = 28.33700180053711,
            //    OffsetX = 25,
            //    OffsetY = 24.168500900268555,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(networkshapes120);
            //NodeGroup NetworkShapes121 = new NodeGroup()
            //{
            //    ID = "Network Cloud",
            //    Children = new string[] {
            //   "network cloud1",
            //   "network cloud2"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes121);
            //Node NetworkShapes122 = new Node()
            //{
            //    ID = "Outlet1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M6.1,49 C5.49248678,49 5,48.5075132 5,47.9 L5,2.1 C5,1.49248678 5.49248678,1 6.1,1 L43.9689655,1 C44.5764787,1 45.0689655,1.49248678 45.0689655,2.1 L45.0689655,47.9 C45.0689655,48.5075132 44.5764787,49 43.9689655,49 L6.1,49 Z"
            //    },
            //    Width = 40.068965911865234,
            //    Height = 48,
            //    OffsetX = 25.034482955932617,
            //    OffsetY = 25,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes122);
            //Node NetworkShapes123 = new Node()
            //{
            //    ID = "Outlet2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M7,47 L7,3 L43.0689655,3 L43.0689655,47 L7,47 Z M15.9310345,23.1206897 L34.137931,23.1206897 C35.5186429,23.1206897 36.637931,22.0014015 36.637931,20.6206897 L36.637931,10.3448276 C36.637931,8.96411571 35.5186429,7.84482759 34.137931,7.84482759 L15.9310345,7.84482759 C14.5503226,7.84482759 13.4310345,8.96411571 13.4310345,10.3448276 L13.4310345,20.6206897 C13.4310345,22.0014015 14.5503226,23.1206897 15.9310345,23.1206897 Z M13.4310345,39.6551724 C13.4310345,41.0358843 14.5503226,42.1551724 15.9310345,42.1551724 L34.137931,42.1551724 C35.5186429,42.1551724 36.637931,41.0358843 36.637931,39.6551724 L36.637931,29.3793103 C36.637931,27.9985985 35.5186429,26.8793103 34.137931,26.8793103 L15.9310345,26.8793103 C14.5503226,26.8793103 13.4310345,27.9985985 13.4310345,29.3793103 L13.4310345,39.6551724 Z M15.9310345,22.1206897 C15.1026074,22.1206897 14.4310345,21.4491168 14.4310345,20.6206897 L14.4310345,10.3448276 C14.4310345,9.51640046 15.1026074,8.84482759 15.9310345,8.84482759 L34.137931,8.84482759 C34.9663582,8.84482759 35.637931,9.51640046 35.637931,10.3448276 L35.637931,20.6206897 C35.637931,21.4491168 34.9663582,22.1206897 34.137931,22.1206897 L15.9310345,22.1206897 Z M19.7758621,13.1034483 L19.7758621,14.6896552 C19.7758621,14.9657975 19.9997197,15.1896552 20.2758621,15.1896552 C20.5520044,15.1896552 20.7758621,14.9657975 20.7758621,14.6896552 L20.7758621,13.1034483 C20.7758621,12.8273059 20.5520044,12.6034483 20.2758621,12.6034483 C19.9997197,12.6034483 19.7758621,12.8273059 19.7758621,13.1034483 Z M29.2931034,13.1034483 L29.2931034,14.6896552 C29.2931034,14.9657975 29.5169611,15.1896552 29.7931034,15.1896552 C30.0692458,15.1896552 30.2931034,14.9657975 30.2931034,14.6896552 L30.2931034,13.1034483 C30.2931034,12.8273059 30.0692458,12.6034483 29.7931034,12.6034483 C29.5169611,12.6034483 29.2931034,12.8273059 29.2931034,13.1034483 Z M25.0344828,16.2758621 C24.1584449,16.2758621 23.4482759,16.9860311 23.4482759,17.862069 L23.4482759,19.4482759 L26.6206897,19.4482759 L26.6206897,17.862069 C26.6206897,16.9860311 25.9105206,16.2758621 25.0344828,16.2758621 Z M34.137931,41.1551724 L15.9310345,41.1551724 C15.1026074,41.1551724 14.4310345,40.4835995 14.4310345,39.6551724 L14.4310345,29.3793103 C14.4310345,28.5508832 15.1026074,27.8793103 15.9310345,27.8793103 L34.137931,27.8793103 C34.9663582,27.8793103 35.637931,28.5508832 35.637931,29.3793103 L35.637931,39.6551724 C35.637931,40.4835995 34.9663582,41.1551724 34.137931,41.1551724 Z M25.0344828,35.3103448 C24.1584449,35.3103448 23.4482759,36.0205138 23.4482759,36.8965517 L23.4482759,38.4827586 L26.6206897,38.4827586 L26.6206897,36.8965517 C26.6206897,36.0205138 25.9105206,35.3103448 25.0344828,35.3103448 Z M19.7758621,32.137931 L19.7758621,33.7241379 C19.7758621,34.0002803 19.9997197,34.2241379 20.2758621,34.2241379 C20.5520044,34.2241379 20.7758621,34.0002803 20.7758621,33.7241379 L20.7758621,32.137931 C20.7758621,31.8617887 20.5520044,31.637931 20.2758621,31.637931 C19.9997197,31.637931 19.7758621,31.8617887 19.7758621,32.137931 Z M29.2931034,32.137931 L29.2931034,33.7241379 C29.2931034,34.0002803 29.5169611,34.2241379 29.7931034,34.2241379 C30.0692458,34.2241379 30.2931034,34.0002803 30.2931034,33.7241379 L30.2931034,32.137931 C30.2931034,31.8617887 30.0692458,31.637931 29.7931034,31.637931 C29.5169611,31.637931 29.2931034,31.8617887 29.2931034,32.137931 Z"
            //    },
            //    Width = 36.068965911865234,
            //    Height = 44,
            //    OffsetX = 25.034482955932617,
            //    OffsetY = 25,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes123);
            //NodeGroup NetworkShapes124 = new NodeGroup()
            //{
            //    ID = "Outlet",
            //    Children = new string[] {
            //   "Outlet1",
            //   "Outlet2"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes124);
            //Node NetworkShapes125 = new Node()
            //{
            //    ID = "PC1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M16,31 L16,37.9 C16,38.5075132 15.5075132,39 14.9,39 L2.1,39 C1.49248678,39 1,38.5075132 1,37.9 L1,13.1 C1,12.4924868 1.49248678,12 2.1,12 L8,12 L8,7.1 C8,6.49248678 8.49248678,6 9.1,6 L46.9,6 C47.5075132,6 48,6.49248678 48,7.1 L48,29.9 C48,30.5075132 47.5075132,31 46.9,31 L32,31 L32,36.5 L35,36.5 C35.5522847,36.5 36,36.9477153 36,37.5 C36,38.0522847 35.5522847,38.5 35,38.5 L19,38.5 C18.4477153,38.5 18,38.0522847 18,37.5 C18,36.9477153 18.4477153,36.5 19,36.5 L23,36.5 L23,31 L16,31 Z M25,36.5 L30,36.5 L30,31 L25,31 L25,36.5 Z"
            //    },
            //    Width = 47,
            //    Height = 33,
            //    OffsetX = 24.5,
            //    OffsetY = 22.5,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes125);
            //Node NetworkShapes126 = new Node()
            //{
            //    ID = "PC2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M10,12 L10,8 L46,8 L46,29 L16,29 L16,13.1 C16,12.4924868 15.5075132,12 14.9,12 L10,12 Z M14,37 L3,37 L3,14 L14,14 L14,37 Z"
            //    },
            //    Width = 43,
            //    Height = 29,
            //    OffsetX = 24.5,
            //    OffsetY = 22.5,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes126);
            //Node NetworkShapes127 = new Node()
            //{
            //    ID = "PC3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M6.5,25 C6.22385763,25 6,24.7761424 6,24.5 C6,24.2238576 6.22385763,24 6.5,24 L10.5,24 C10.7761424,24 11,24.2238576 11,24.5 C11,24.7761424 10.7761424,25 10.5,25 L6.5,25 Z M6.5,21 C6.22385763,21 6,20.7761424 6,20.5 C6,20.2238576 6.22385763,20 6.5,20 L10.5,20 C10.7761424,20 11,20.2238576 11,20.5 C11,20.7761424 10.7761424,21 10.5,21 L6.5,21 Z M8,33 C7.44771525,33 7,32.5522847 7,32 C7,31.4477153 7.44771525,31 8,31 L9,31 C9.55228475,31 10,31.4477153 10,32 C10,32.5522847 9.55228475,33 9,33 L8,33 Z"
            //    },
            //    Width = 5,
            //    Height = 13,
            //    OffsetX = 8.5,
            //    OffsetY = 26.5,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes127);
            //NodeGroup NetworkShapes128 = new NodeGroup()
            //{
            //    ID = "PC",
            //    Children = new string[] {
            //   "PC1",
            //   "PC2",
            //   "PC3"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes128);
            //Node NetworkShapes129 = new Node()
            //{
            //    ID = "Phone11",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M34.3450977,20.8671875 C35.7569922,20.8671875 37.0854219,21.6193594 37.8118984,22.8300039 C37.8893438,22.9591094 37.4489297,21.9078477 44.7901523,39.7554883 C45.1308398,40.5746836 45.3046875,41.4451797 45.3046875,42.3377773 L45.3046875,43.9570312 C45.3046875,46.1863242 43.4910117,48 41.2617188,48 L8.73828125,48 C6.50898828,48 4.6953125,46.1863242 4.6953125,43.9570312 L4.6953125,42.3377773 C4.6953125,41.4453594 4.86907031,40.5749531 5.21173437,39.7508164 L12.0974492,23.0107695 C12.4900664,22.0559102 13.909418,20.8671875 15.6549922,20.8671875 L18.171875,20.8671875 L18.171875,19.5195312 C18.171875,17.2902383 19.9855508,15.4765625 22.2148438,15.4765625 L27.7851563,15.4765625 C30.0144492,15.4765625 31.828125,17.2902383 31.828125,19.5195312 L31.828125,20.8671875 L34.3450977,20.8671875 Z M35.8710938,2 C42.5589727,2 48,7.44102734 48,14.1289063 L48,16.8242188 C48,19.0535117 46.1863242,20.8671875 43.9570312,20.8671875 L38.5664062,20.8671875 C36.3371133,20.8671875 34.5234375,19.0535117 34.5234375,16.8242188 L34.5234375,14.1289063 C34.5234375,13.3858086 33.9188789,12.78125 33.1757812,12.78125 L16.8242188,12.78125 C16.0811211,12.78125 15.4765625,13.3858086 15.4765625,14.1289063 L15.4765625,16.8242188 C15.4765625,19.0535117 13.6628867,20.8671875 11.4335938,20.8671875 L6.04296875,20.8671875 C3.81367578,20.8671875 2,19.0535117 2,16.8242188 L2,14.1289063 C2,7.44102734 7.44102734,2 14.1289062,2 L35.8710938,2 Z"
            //    },
            //    Width = 46,
            //    Height = 46,
            //    OffsetX = 25,
            //    OffsetY = 25,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes129);
            //Node NetworkShapes130 = new Node()
            //{
            //    ID = "Phone12",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M11.460968,18.66819 L6.07034302,18.66819 C5.05110299,18.66819 4.22268677,17.8397738 4.22268677,16.8205338 L4.22268677,14.9728775 L13.3086243,14.9728775 L13.3086243,16.8205338 C13.3086243,17.8397738 12.480208,18.66819 11.460968,18.66819 Z M33.1757812,10.6108551 L16.8242187,10.6108551 C15.3144787,10.6108551 13.9819507,11.5701635 13.4842843,12.973306 L13.3662251,13.3061676 L4.21501248,13.3061676 L4.29706647,12.7350602 C4.99466462,7.87967769 9.17984053,4.2202301 14.1289062,4.2202301 L35.8710937,4.2202301 C40.8202187,4.2202301 45.0053309,7.87964675 45.7029335,12.7350602 L45.7849875,13.3061676 L36.6337749,13.3061676 L36.5157157,12.973306 C36.0180493,11.5701635 34.6855213,10.6108551 33.1757812,10.6108551 Z M43.9638748,18.671524 L38.5732498,18.671524 C37.5540098,18.671524 36.7255936,17.8431078 36.7255936,16.8238678 L36.7255936,14.9762115 L45.8115311,14.9762115 L45.8115311,16.8238678 C45.8115311,17.8431078 44.9831148,18.671524 43.9638748,18.671524 Z M43.109375,43.9570312 C43.109375,44.9762713 42.2809588,45.8046875 41.2617188,45.8046875 L8.73828125,45.8046875 C7.71904122,45.8046875 6.890625,44.9762713 6.890625,43.9570312 L6.890625,42.3377773 C6.890625,41.735692 7.00814679,41.1482607 7.23997448,40.5905786 L14.0823846,23.9560981 L14.133124,23.8625289 C14.4766423,23.3641925 15.0489697,23.0625 15.6549922,23.0625 L34.3450977,23.0625 C34.9510472,23.0625 35.5233673,23.3642063 35.866876,23.8625289 L35.9176155,23.9560986 L42.7612785,40.5936806 C42.9921377,41.1489332 43.109375,41.7363409 43.109375,42.3377773 L43.109375,43.9570312 Z M20.3671875,19.5195312 C20.3671875,18.5002912 21.1956037,17.671875 22.2148438,17.671875 L27.7851562,17.671875 C28.8043963,17.671875 29.6328125,18.5002912 29.6328125,19.5195312 L29.6328125,21.3671875 L20.3671875,21.3671875 L20.3671875,19.5195312 Z M25.0898438,25.2578125 C20.0789731,25.2578125 16.0039062,29.3328793 16.0039062,34.34375 C16.0039062,39.3546207 20.0789731,43.4296875 25.0898438,43.4296875 C30.1007144,43.4296875 34.1757812,39.3546207 34.1757812,34.34375 C34.1757812,29.3328793 30.1007144,25.2578125 25.0898438,25.2578125 Z M25.0898438,27.2578125 C28.9961449,27.2578125 32.1757812,30.4374488 32.1757812,34.34375 C32.1757812,38.2500512 28.9961449,41.4296875 25.0898438,41.4296875 C21.1835426,41.4296875 18.0039062,38.2500512 18.0039062,34.34375 C18.0039062,30.4374488 21.1835426,27.2578125 25.0898438,27.2578125 Z M25.0898438,31.6484375 C23.6036484,31.6484375 22.3945312,32.8575547 22.3945312,34.34375 C22.3945312,35.8299453 23.6036484,37.0390625 25.0898438,37.0390625 C26.5760391,37.0390625 27.7851562,35.8299453 27.7851562,34.34375 C27.7851562,32.8575547 26.5760391,31.6484375 25.0898438,31.6484375 Z"
            //    },
            //    Width = 41.596519470214844,
            //    Height = 41.58445739746094,
            //    OffsetX = 25.013272285461426,
            //    OffsetY = 25.01245880126953,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes130);
            //NodeGroup NetworkShapes131 = new NodeGroup()
            //{
            //    ID = "Phone1",
            //    Children = new string[] {
            //   "Phone11",
            //   "Phone12"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes131);
            //Node NetworkShapes132 = new Node()
            //{
            //    ID = "Phone21",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M6,6 L6,5.5 C6,4.11928813 7.11928813,3 8.5,3 L18.1896552,3 C19.570367,3 20.6896552,4.11928813 20.6896552,5.5 L20.6896552,6 L47.9,6 C48.5075132,6 49,6.49248678 49,7.1 L49,43.3827586 C49,43.9902718 48.5075132,44.4827586 47.9,44.4827586 L20.6896552,44.4827586 L20.6896552,45.3275862 C20.6896552,46.7082981 19.570367,47.8275862 18.1896552,47.8275862 L8.5,47.8275862 C7.11928813,47.8275862 6,46.7082981 6,45.3275862 L6,44.4827586 L2.1,44.4827586 C1.49248678,44.4827586 1,43.9902718 1,43.3827586 L1,7.1 C1,6.49248678 1.49248678,6 2.1,6 L6,6 Z"
            //    },
            //    Width = 48,
            //    Height = 44.82758712768555,
            //    OffsetX = 25,
            //    OffsetY = 25.413793563842773,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes132);
            //Node NetworkShapes133 = new Node()
            //{
            //    ID = "Phone22",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M6,8 L6,42.4827586 L3,42.4827586 L3,8 L6,8 Z M20.6896552,8 L47,8 L47,42.4827586 L20.6896552,42.4827586 L20.6896552,8 Z M42.7343876,17.1343876 L42.7343876,12.5757669 C42.7343876,12.2443961 42.4657585,11.9757669 42.1343876,11.9757669 L23.6242331,11.9757669 C23.2928622,11.9757669 23.0242331,12.2443961 23.0242331,12.5757669 L23.0242331,17.1343876 C23.0242331,17.4657585 23.2928622,17.7343876 23.6242331,17.7343876 L42.1343876,17.7343876 C42.4657585,17.7343876 42.7343876,17.4657585 42.7343876,17.1343876 Z M25.5862069,25.0862069 L27.1724138,25.0862069 C27.4485562,25.0862069 27.6724138,24.8623493 27.6724138,24.5862069 C27.6724138,24.3100645 27.4485562,24.0862069 27.1724138,24.0862069 L25.5862069,24.0862069 C25.3100645,24.0862069 25.0862069,24.3100645 25.0862069,24.5862069 C25.0862069,24.8623493 25.3100645,25.0862069 25.5862069,25.0862069 Z M30.5862069,25.0862069 L32.1724138,25.0862069 C32.4485562,25.0862069 32.6724138,24.8623493 32.6724138,24.5862069 C32.6724138,24.3100645 32.4485562,24.0862069 32.1724138,24.0862069 L30.5862069,24.0862069 C30.3100645,24.0862069 30.0862069,24.3100645 30.0862069,24.5862069 C30.0862069,24.8623493 30.3100645,25.0862069 30.5862069,25.0862069 Z M35.5862069,25.0862069 L37.1724138,25.0862069 C37.4485562,25.0862069 37.6724138,24.8623493 37.6724138,24.5862069 C37.6724138,24.3100645 37.4485562,24.0862069 37.1724138,24.0862069 L35.5862069,24.0862069 C35.3100645,24.0862069 35.0862069,24.3100645 35.0862069,24.5862069 C35.0862069,24.8623493 35.3100645,25.0862069 35.5862069,25.0862069 Z M39.5862069,25.0862069 L41.1724138,25.0862069 C41.4485562,25.0862069 41.6724138,24.8623493 41.6724138,24.5862069 C41.6724138,24.3100645 41.4485562,24.0862069 41.1724138,24.0862069 L39.5862069,24.0862069 C39.3100645,24.0862069 39.0862069,24.3100645 39.0862069,24.5862069 C39.0862069,24.8623493 39.3100645,25.0862069 39.5862069,25.0862069 Z M25.5862069,28.0862069 L27.1724138,28.0862069 C27.4485562,28.0862069 27.6724138,27.8623493 27.6724138,27.5862069 C27.6724138,27.3100645 27.4485562,27.0862069 27.1724138,27.0862069 L25.5862069,27.0862069 C25.3100645,27.0862069 25.0862069,27.3100645 25.0862069,27.5862069 C25.0862069,27.8623493 25.3100645,28.0862069 25.5862069,28.0862069 Z M30.5862069,28.0862069 L32.1724138,28.0862069 C32.4485562,28.0862069 32.6724138,27.8623493 32.6724138,27.5862069 C32.6724138,27.3100645 32.4485562,27.0862069 32.1724138,27.0862069 L30.5862069,27.0862069 C30.3100645,27.0862069 30.0862069,27.3100645 30.0862069,27.5862069 C30.0862069,27.8623493 30.3100645,28.0862069 30.5862069,28.0862069 Z M35.5862069,28.0862069 L37.1724138,28.0862069 C37.4485562,28.0862069 37.6724138,27.8623493 37.6724138,27.5862069 C37.6724138,27.3100645 37.4485562,27.0862069 37.1724138,27.0862069 L35.5862069,27.0862069 C35.3100645,27.0862069 35.0862069,27.3100645 35.0862069,27.5862069 C35.0862069,27.8623493 35.3100645,28.0862069 35.5862069,28.0862069 Z M39.5862069,28.0862069 L41.1724138,28.0862069 C41.4485562,28.0862069 41.6724138,27.8623493 41.6724138,27.5862069 C41.6724138,27.3100645 41.4485562,27.0862069 41.1724138,27.0862069 L39.5862069,27.0862069 C39.3100645,27.0862069 39.0862069,27.3100645 39.0862069,27.5862069 C39.0862069,27.8623493 39.3100645,28.0862069 39.5862069,28.0862069 Z M25.5862069,31.0862069 L27.1724138,31.0862069 C27.4485562,31.0862069 27.6724138,30.8623493 27.6724138,30.5862069 C27.6724138,30.3100645 27.4485562,30.0862069 27.1724138,30.0862069 L25.5862069,30.0862069 C25.3100645,30.0862069 25.0862069,30.3100645 25.0862069,30.5862069 C25.0862069,30.8623493 25.3100645,31.0862069 25.5862069,31.0862069 Z M30.5862069,31.0862069 L32.1724138,31.0862069 C32.4485562,31.0862069 32.6724138,30.8623493 32.6724138,30.5862069 C32.6724138,30.3100645 32.4485562,30.0862069 32.1724138,30.0862069 L30.5862069,30.0862069 C30.3100645,30.0862069 30.0862069,30.3100645 30.0862069,30.5862069 C30.0862069,30.8623493 30.3100645,31.0862069 30.5862069,31.0862069 Z M35.5862069,31.0862069 L37.1724138,31.0862069 C37.4485562,31.0862069 37.6724138,30.8623493 37.6724138,30.5862069 C37.6724138,30.3100645 37.4485562,30.0862069 37.1724138,30.0862069 L35.5862069,30.0862069 C35.3100645,30.0862069 35.0862069,30.3100645 35.0862069,30.5862069 C35.0862069,30.8623493 35.3100645,31.0862069 35.5862069,31.0862069 Z M39.5862069,31.0862069 L41.1724138,31.0862069 C41.4485562,31.0862069 41.6724138,30.8623493 41.6724138,30.5862069 C41.6724138,30.3100645 41.4485562,30.0862069 41.1724138,30.0862069 L39.5862069,30.0862069 C39.3100645,30.0862069 39.0862069,30.3100645 39.0862069,30.5862069 C39.0862069,30.8623493 39.3100645,31.0862069 39.5862069,31.0862069 Z M25.5862069,34.0862069 L27.1724138,34.0862069 C27.4485562,34.0862069 27.6724138,33.8623493 27.6724138,33.5862069 C27.6724138,33.3100645 27.4485562,33.0862069 27.1724138,33.0862069 L25.5862069,33.0862069 C25.3100645,33.0862069 25.0862069,33.3100645 25.0862069,33.5862069 C25.0862069,33.8623493 25.3100645,34.0862069 25.5862069,34.0862069 Z M30.5862069,34.0862069 L32.1724138,34.0862069 C32.4485562,34.0862069 32.6724138,33.8623493 32.6724138,33.5862069 C32.6724138,33.3100645 32.4485562,33.0862069 32.1724138,33.0862069 L30.5862069,33.0862069 C30.3100645,33.0862069 30.0862069,33.3100645 30.0862069,33.5862069 C30.0862069,33.8623493 30.3100645,34.0862069 30.5862069,34.0862069 Z M35.5862069,34.0862069 L37.1724138,34.0862069 C37.4485562,34.0862069 37.6724138,33.8623493 37.6724138,33.5862069 C37.6724138,33.3100645 37.4485562,33.0862069 37.1724138,33.0862069 L35.5862069,33.0862069 C35.3100645,33.0862069 35.0862069,33.3100645 35.0862069,33.5862069 C35.0862069,33.8623493 35.3100645,34.0862069 35.5862069,34.0862069 Z M39.5862069,34.0862069 L41.1724138,34.0862069 C41.4485562,34.0862069 41.6724138,33.8623493 41.6724138,33.5862069 C41.6724138,33.3100645 41.4485562,33.0862069 41.1724138,33.0862069 L39.5862069,33.0862069 C39.3100645,33.0862069 39.0862069,33.3100645 39.0862069,33.5862069 C39.0862069,33.8623493 39.3100645,34.0862069 39.5862069,34.0862069 Z M8.5,45.8275862 C8.22385763,45.8275862 8,45.6037286 8,45.3275862 L8,5.5 C8,5.22385763 8.22385763,5 8.5,5 L18.1896552,5 C18.4657975,5 18.6896552,5.22385763 18.6896552,5.5 L18.6896552,45.3275862 C18.6896552,45.6037286 18.4657975,45.8275862 18.1896552,45.8275862 L8.5,45.8275862 Z M41.7343876,12.9757669 L41.7343876,16.7343876 L24.0242331,16.7343876 L24.0242331,12.9757669 L41.7343876,12.9757669 Z"
            //    },
            //    Width = 44,
            //    Height = 40.82758712768555,
            //    OffsetX = 25,
            //    OffsetY = 25.413793563842773,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes133);
            //NodeGroup NetworkShapes134 = new NodeGroup()
            //{
            //    ID = "Phone2",
            //    Children = new string[] {
            //   "Phone21",
            //   "Phone22"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes134);
            //Node NetworkShapes135 = new Node()
            //{
            //    ID = "PowerStrip1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M2.1,37.3061968 C1.49248678,37.3061968 1,36.81371 1,36.2061968 L1,14.1 C1,13.4924868 1.49248678,13 2.1,13 L47.9,13 C48.5075132,13 49,13.4924868 49,14.1 L49,36.2061968 C49,36.81371 48.5075132,37.3061968 47.9,37.3061968 L2.1,37.3061968 Z"
            //    },
            //    Width = 48,
            //    Height = 24.306198120117188,
            //    OffsetX = 25,
            //    OffsetY = 25.153099060058594,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes135);
            //Node NetworkShapes136 = new Node()
            //{
            //    ID = "PowerStrip2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M2.68247363,35.5992765 L2.68247363,14.7069203 L47.3175264,14.7069203 L47.3175264,23.958553 L47.3175264,35.5992765 L2.68247363,35.5992765 Z M7.55087003,31.9199219 L21.6720821,31.9199219 C23.052794,31.9199219 24.1720821,30.8006338 24.1720821,29.4199219 L24.1720821,20.8744674 C24.1720821,19.4937555 23.052794,18.3744674 21.6720821,18.3744674 L7.55087003,18.3744674 C6.17015815,18.3744674 5.05087003,19.4937555 5.05087003,20.8744674 L5.05087003,29.4199219 C5.05087003,30.8006338 6.17015815,31.9199219 7.55087003,31.9199219 Z M28.4599609,31.9199219 L42.5811731,31.9199219 C43.9618849,31.9199219 45.0811731,30.8006338 45.0811731,29.4199219 L45.0811731,20.8744674 C45.0811731,19.4937555 43.9618849,18.3744674 42.5811731,18.3744674 L28.4599609,18.3744674 C27.0792491,18.3744674 25.9599609,19.4937555 25.9599609,20.8744674 L25.9599609,29.4199219 C25.9599609,30.8006338 27.0792491,31.9199219 28.4599609,31.9199219 Z M7.55087003,30.9199219 C6.7224429,30.9199219 6.05087003,30.2483491 6.05087003,29.4199219 L6.05087003,20.8744674 C6.05087003,20.0460403 6.7224429,19.3744674 7.55087003,19.3744674 L21.6720821,19.3744674 C22.5005093,19.3744674 23.1720821,20.0460403 23.1720821,20.8744674 L23.1720821,29.4199219 C23.1720821,30.2483491 22.5005093,30.9199219 21.6720821,30.9199219 L7.55087003,30.9199219 Z M14.5454545,26.548621 C13.7756031,26.548621 13.1515152,27.172709 13.1515152,27.9425604 L13.1515152,29.3364998 L15.9393939,29.3364998 L15.9393939,27.9425604 C15.9393939,27.172709 15.315306,26.548621 14.5454545,26.548621 Z M9.86363636,23.7607422 L9.86363636,25.1546816 C9.86363636,25.430824 10.087494,25.6546816 10.3636364,25.6546816 C10.6397787,25.6546816 10.8636364,25.430824 10.8636364,25.1546816 L10.8636364,23.7607422 C10.8636364,23.4845999 10.6397787,23.2607422 10.3636364,23.2607422 C10.087494,23.2607422 9.86363636,23.4845999 9.86363636,23.7607422 Z M18.2272727,23.7607422 L18.2272727,25.1546816 C18.2272727,25.430824 18.4511304,25.6546816 18.7272727,25.6546816 C19.0034151,25.6546816 19.2272727,25.430824 19.2272727,25.1546816 L19.2272727,23.7607422 C19.2272727,23.4845999 19.0034151,23.2607422 18.7272727,23.2607422 C18.4511304,23.2607422 18.2272727,23.4845999 18.2272727,23.7607422 Z M28.4599609,30.9199219 C27.6315338,30.9199219 26.9599609,30.2483491 26.9599609,29.4199219 L26.9599609,20.8744674 C26.9599609,20.0460403 27.6315338,19.3744674 28.4599609,19.3744674 L42.5811731,19.3744674 C43.4096002,19.3744674 44.0811731,20.0460403 44.0811731,20.8744674 L44.0811731,29.4199219 C44.0811731,30.2483491 43.4096002,30.9199219 42.5811731,30.9199219 L28.4599609,30.9199219 Z M35.4545455,26.548621 C34.684694,26.548621 34.0606061,27.172709 34.0606061,27.9425604 L34.0606061,29.3364998 L36.8484848,29.3364998 L36.8484848,27.9425604 C36.8484848,27.172709 36.2243969,26.548621 35.4545455,26.548621 Z M30.7727273,23.7607422 L30.7727273,25.1546816 C30.7727273,25.430824 30.9965849,25.6546816 31.2727273,25.6546816 C31.5488696,25.6546816 31.7727273,25.430824 31.7727273,25.1546816 L31.7727273,23.7607422 C31.7727273,23.4845999 31.5488696,23.2607422 31.2727273,23.2607422 C30.9965849,23.2607422 30.7727273,23.4845999 30.7727273,23.7607422 Z M39.1363636,23.7607422 L39.1363636,25.1546816 C39.1363636,25.430824 39.3602213,25.6546816 39.6363636,25.6546816 C39.912506,25.6546816 40.1363636,25.430824 40.1363636,25.1546816 L40.1363636,23.7607422 C40.1363636,23.4845999 39.912506,23.2607422 39.6363636,23.2607422 C39.3602213,23.2607422 39.1363636,23.4845999 39.1363636,23.7607422 Z"
            //    },
            //    Width = 44.63505554199219,
            //    Height = 20.892356872558594,
            //    OffsetX = 25.000001430511475,
            //    OffsetY = 25.153099060058594,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes136);
            //NodeGroup NetworkShapes137 = new NodeGroup()
            //{
            //    ID = "Power Strip",
            //    Children = new string[] {
            //   "PowerStrip1",
            //   "PowerStrip2"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes137);
            //Node NetworkShapes138 = new Node()
            //{
            //    ID = "Printer1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M39.7777778,35.3703704 L39.7777778,47.9 C39.7777778,48.5075132 39.285291,49 38.6777778,49 L11.6185185,49 C11.0110053,49 10.5185185,48.5075132 10.5185185,47.9 L10.5185185,35.3703704 L3.1,35.3703704 C2.49248678,35.3703704 2,34.8778836 2,34.2703704 L2,12.3222222 C2,11.714709 2.49248678,11.2222222 3.1,11.2222222 L12.2222222,11.2222222 L12.2222222,2.1 C12.2222222,1.49248678 12.714709,1 13.3222222,1 L38.6777778,1 C39.285291,1 39.7777778,1.49248678 39.7777778,2.1 L39.7777778,11.2222222 L47.1962963,11.2222222 C47.8038095,11.2222222 48.2962963,11.714709 48.2962963,12.3222222 L48.2962963,34.2703704 C48.2962963,34.8778836 47.8038095,35.3703704 47.1962963,35.3703704 L39.7777778,35.3703704 Z M14.2222222,11.2222222 L37.7777778,11.2222222 L37.7777778,3 L14.2222222,3 L14.2222222,11.2222222 Z"
            //    },
            //    Width = 46.296295166015625,
            //    Height = 48,
            //    OffsetX = 25.148147583007812,
            //    OffsetY = 25,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes138);
            //Node NetworkShapes139 = new Node()
            //{
            //    ID = "Printer2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M39.7777778,33.3703704 L39.7777778,25.9518519 C39.7777778,25.3443386 39.285291,24.8518519 38.6777778,24.8518519 L11.6185185,24.8518519 C11.0110053,24.8518519 10.5185185,25.3443386 10.5185185,25.9518519 L10.5185185,33.3703704 L4,33.3703704 L4,13.2222222 L46.2962963,13.2222222 L46.2962963,33.3703704 L39.7777778,33.3703704 Z"
            //    },
            //    Width = 42.296295166015625,
            //    Height = 20.148147583007812,
            //    OffsetX = 25.148147583007812,
            //    OffsetY = 23.29629611968994,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes139);
            //Node NetworkShapes140 = new Node()
            //{
            //    ID = "Printer3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M12.5185185,47 L12.5185185,26.8518519 L37.7777778,26.8518519 L37.7777778,47 L12.5185185,47 Z M38.7777778,18.1851852 C38.7777778,16.7745185 39.9226667,15.6296296 41.3333333,15.6296296 C42.744,15.6296296 43.8888889,16.7745185 43.8888889,18.1851852 C43.8888889,19.5958519 42.744,20.7407407 41.3333333,20.7407407 C39.9226667,20.7407407 38.7777778,19.5958519 38.7777778,18.1851852 Z M20.037037,33.6666667 L30.2592593,33.6666667 C30.811544,33.6666667 31.2592593,33.2189514 31.2592593,32.6666667 C31.2592593,32.1143819 30.811544,31.6666667 30.2592593,31.6666667 L20.037037,31.6666667 C19.4847523,31.6666667 19.037037,32.1143819 19.037037,32.6666667 C19.037037,33.2189514 19.4847523,33.6666667 20.037037,33.6666667 Z M20.037037,40.4814815 L30.2592593,40.4814815 C30.811544,40.4814815 31.2592593,40.0337662 31.2592593,39.4814815 C31.2592593,38.9291967 30.811544,38.4814815 30.2592593,38.4814815 L20.037037,38.4814815 C19.4847523,38.4814815 19.037037,38.9291967 19.037037,39.4814815 C19.037037,40.0337662 19.4847523,40.4814815 20.037037,40.4814815 Z"
            //    },
            //    Width = 31.370370864868164,
            //    Height = 31.370370864868164,
            //    OffsetX = 28.20370388031006,
            //    OffsetY = 31.314814567565918,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes140);
            //NodeGroup NetworkShapes141 = new NodeGroup()
            //{
            //    ID = "Printer",
            //    Children = new string[] {
            //   "Printer1",
            //   "Printer2",
            //   "Printer3"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes141);
            //Node NetworkShapes142 = new Node()
            //{
            //    ID = "Proxy Server1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M18.9393939,46.6060606 L30.4848485,46.6060606 C31.0371332,46.6060606 31.4848485,47.0537759 31.4848485,47.6060606 C31.4848485,48.1583454 31.0371332,48.6060606 30.4848485,48.6060606 L5.39393939,48.6060606 C4.84165464,48.6060606 4.39393939,48.1583454 4.39393939,47.6060606 C4.39393939,47.0537759 4.84165464,46.6060606 5.39393939,46.6060606 L16.9393939,46.6060606 L16.9393939,41.6363636 L5,41.6363636 C3.8954305,41.6363636 3,40.7409331 3,39.6363636 L3,30.4848485 C3,30.1205613 3.09739429,29.7790219 3.26756439,29.4848485 C3.09739429,29.1906751 3,28.8491356 3,28.4848485 L3,19.3333333 C3,18.9690462 3.09739429,18.6275067 3.26756439,18.3333333 C3.09739429,18.03916 3,17.6976205 3,17.3333333 L3,8.18181818 C3,7.07724868 3.8954305,6.18181818 5,6.18181818 L22.4982199,6.18181818 C25.076871,3.5988594 28.6409677,2 32.5757576,2 C40.4367363,2 46.8181818,8.38146546 46.8181818,16.2424242 C46.8181818,24.103442 40.4367658,30.4848485 32.5757576,30.4848485 C32.2085877,30.4848485 31.8446458,30.4709267 31.4844312,30.4435827 C31.484709,30.4573045 31.4848485,30.4710602 31.4848485,30.4848485 L31.4848485,39.6363636 C31.4848485,40.7409331 30.589418,41.6363636 29.4848485,41.6363636 L18.9393939,41.6363636 L18.9393939,46.6060606 Z"
            //    },
            //    Width = 43.818180084228516,
            //    Height = 46.60606002807617,
            //    OffsetX = 24.909090042114258,
            //    OffsetY = 25.303030014038086,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes142);
            //Node NetworkShapes143 = new Node()
            //{
            //    ID = "Proxy Server2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M18.6702113,19.3333333 C19.5308594,23.2169898 21.9788138,26.5063708 25.2974424,28.4848485 L5,28.4848485 L5,19.3333333 L18.6702113,19.3333333 Z M18.3745674,17.3333333 L5,17.3333333 L5,8.18181818 L20.8349937,8.18181818 C19.2572326,10.4744602 18.3333333,13.2513425 18.3333333,16.2424242 C18.3333333,16.6094523 18.3472443,16.973255 18.3745674,17.3333333 Z M5,39.6363636 L5,30.4848485 L29.4848485,30.4848485 L29.4848485,39.6363636 L5,39.6363636 Z M23.8572923,7.65163313 C26.0782023,5.39797272 29.1651169,4 32.5757576,4 C34.4991691,4 36.3196249,4.44460176 37.9398658,5.23654481 L37.9398658,7.65163313 L23.8572923,7.65163313 Z M38.8701925,5.74236596 C39.7574227,6.27576482 40.5716564,6.91841141 41.2942229,7.65163313 L38.8701925,7.65163313 L38.8701925,5.74236596 Z M34.6759699,28.3050328 C33.9935119,28.4232376 33.2917687,28.4848485 32.5757576,28.4848485 C30.2837995,28.4848485 28.1380378,27.8535547 26.3030303,26.7555239 L26.3030303,25.3030303 L34.6759699,25.3030303 L34.6759699,28.3050328 Z M40.8050896,25.3030303 C39.3957646,26.5839952 37.6868482,27.5410392 35.7965199,28.0559833 L35.7965199,25.3030303 L40.8050896,25.3030303 Z M24.9152931,25.7893825 C24.7303165,25.6407193 24.5497436,25.4867955 24.3738025,25.327839 L24.9152931,25.327839 L24.9152931,25.7893825 Z M20.7065221,13.2335929 C21.1432191,11.5083449 21.9466444,9.9284769 23.0288282,8.58195975 L27.706273,8.58195975 L27.706273,13.2335929 L20.7065221,13.2335929 Z M28.6365996,13.2335929 L28.6365996,8.58195975 L37.0095392,8.58195975 L37.0095392,13.2335929 L28.6365996,13.2335929 Z M42.1226869,8.58195975 C43.2048707,9.9284769 44.008296,11.5083449 44.444993,13.2335929 L37.9398658,13.2335929 L37.9398658,8.58195975 L42.1226869,8.58195975 Z M44.5467841,18.8155526 L25.8456197,18.8155526 L25.8456197,14.1639195 L44.6421025,14.1639195 C44.7578689,14.8395485 44.8181818,15.5340032 44.8181818,16.2424242 C44.8181818,17.1249409 44.7245845,17.9857817 44.5467841,18.8155526 Z M20.6047311,18.8155526 C20.4269307,17.9857817 20.3333333,17.1249409 20.3333333,16.2424242 C20.3333333,15.5340032 20.3936463,14.8395485 20.5094126,14.1639195 L24.9152931,14.1639195 L24.9152931,18.8155526 L20.6047311,18.8155526 Z M23.4482171,24.3975124 C22.2644316,23.0737001 21.3640577,21.4912226 20.8428958,19.7458793 L26.7759463,19.7458793 L26.7759463,24.3975124 L23.4482171,24.3975124 Z M27.706273,24.3975124 L27.706273,19.7458793 L37.9398658,19.7458793 L37.9398658,24.3975124 L27.706273,24.3975124 Z M44.3086194,19.7458793 C43.7874574,21.4912226 42.8870836,23.0737001 41.703298,24.3975124 L38.8701925,24.3975124 L38.8701925,19.7458793 L44.3086194,19.7458793 Z M22.1212121,35.0606061 C22.1212121,34.2911515 21.4967273,33.6666667 20.7272727,33.6666667 C19.9568889,33.6666667 19.3333333,34.2911515 19.3333333,35.0606061 C19.3333333,35.8300606 19.9568889,36.4545455 20.7272727,36.4545455 C21.4967273,36.4545455 22.1212121,35.8300606 22.1212121,35.0606061 Z M26.3030303,35.0606061 C26.3030303,34.2911515 25.6785455,33.6666667 24.9090909,33.6666667 C24.1387071,33.6666667 23.5151515,34.2911515 23.5151515,35.0606061 C23.5151515,35.8300606 24.1387071,36.4545455 24.9090909,36.4545455 C25.6785455,36.4545455 26.3030303,35.8300606 26.3030303,35.0606061 Z"
            //    },
            //    Width = 39.818180084228516,
            //    Height = 35.6363639831543,
            //    OffsetX = 24.909090042114258,
            //    OffsetY = 21.81818199157715,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes143);
            //Node NetworkShapes144 = new Node()
            //{
            //    ID = "Proxy Server3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M22.1212121,35.0606061 C22.1212121,35.8300606 21.4967273,36.4545455 20.7272727,36.4545455 C19.9568889,36.4545455 19.3333333,35.8300606 19.3333333,35.0606061 C19.3333333,34.2911515 19.9568889,33.6666667 20.7272727,33.6666667 C21.4967273,33.6666667 22.1212121,34.2911515 22.1212121,35.0606061"
            //    },
            //    Width = 2.7878780364990234,
            //    Height = 2.7878761291503906,
            //    OffsetX = 20.727272987365723,
            //    OffsetY = 35.06060600280762,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes144);
            //Node NetworkShapes145 = new Node()
            //{
            //    ID = "Proxy Server4",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M26.3030303,35.0606061 C26.3030303,35.8300606 25.6785455,36.4545455 24.9090909,36.4545455 C24.1387071,36.4545455 23.5151515,35.8300606 23.5151515,35.0606061 C23.5151515,34.2911515 24.1387071,33.6666667 24.9090909,33.6666667 C25.6785455,33.6666667 26.3030303,34.2911515 26.3030303,35.0606061"
            //    },
            //    Width = 2.7878780364990234,
            //    Height = 2.7878761291503906,
            //    OffsetX = 24.909090995788574,
            //    OffsetY = 35.06060600280762,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes145);
            //Node NetworkShapes146 = new Node()
            //{
            //    ID = "Proxy Server5",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M44.3086194,19.7458793 L38.8701925,19.7458793 L38.8701925,24.3975124 L41.703298,24.3975124 C41.4197198,24.7146342 41.1198781,25.0169125 40.8050896,25.3030303 L35.7965199,25.3030303 L35.7965199,28.0559833 C35.4295518,28.1559491 35.0557469,28.2392538 34.6759699,28.3050328 L34.6759699,25.3030303 L26.3030303,25.3030303 L26.3030303,26.7555239 C25.8176984,26.4651113 25.3541045,26.1420493 24.9152931,25.7893825 C24.7303164,25.6407193 24.5497436,25.4867955 24.3738025,25.327839 C24.0490116,25.034402 23.7400049,24.7238149 23.4482171,24.3975124 L26.7759463,24.3975124 L26.7759463,19.7458793 L20.8428958,19.7458793 C20.7517338,19.4405827 20.6721746,19.1303029 20.6047311,18.8155526 L24.9152931,18.8155526 L24.9152931,14.1639195 L20.5094126,14.1639195 C20.5632748,13.8495722 20.6291411,13.5393002 20.7065221,13.2335929 L27.706273,13.2335929 L27.706273,8.58195975 L23.0288282,8.58195975 C25.2735031,5.78900245 28.7174922,4 32.5757576,4 C29.1651169,4 26.0782023,5.39797272 23.8572923,7.65163313 L37.9398658,7.65163313 L37.9398658,5.23654481 C37.1297454,4.84057328 36.2695712,4.53143708 35.3715007,4.32129376 C36.6221722,4.61394368 37.7993478,5.0985796 38.8701925,5.74236596 L38.8701925,7.65163313 L41.2942229,7.65163313 C41.585703,7.94741153 41.8622663,8.25792905 42.1226869,8.58195975 L37.9398658,8.58195975 L37.9398658,13.2335929 L44.444993,13.2335929 C44.522374,13.5393002 44.5882404,13.8495722 44.6421025,14.1639195 L25.8456197,14.1639195 L25.8456197,18.8155526 L44.5467841,18.8155526 C44.4793405,19.1303029 44.3997814,19.4405827 44.3086194,19.7458793 Z M8.18181818,13.7575758 L8.18181818,11.7575758 L16.5454545,11.7575758 L16.5454545,13.7575758 L8.18181818,13.7575758 Z M8.18181818,24.9090909 L8.18181818,22.9090909 L16.5454545,22.9090909 L16.5454545,24.9090909 L8.18181818,24.9090909 Z M8.18181818,36.0606061 L8.18181818,34.0606061 L16.5454545,34.0606061 L16.5454545,36.0606061 L8.18181818,36.0606061 Z M28.6365996,13.2335929 L37.0095392,13.2335929 L37.0095392,8.58195975 L28.6365996,8.58195975 L28.6365996,13.2335929 Z M27.706273,24.3975124 L37.9398658,24.3975124 L37.9398658,19.7458793 L27.706273,19.7458793 L27.706273,24.3975124 Z"
            //    },
            //    Width = 36.46028137207031,
            //    Height = 32.06060791015625,
            //    OffsetX = 26.411958694458008,
            //    OffsetY = 20.030303955078125,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes146);
            //NodeGroup NetworkShapes147 = new NodeGroup()
            //{
            //    ID = "Proxy Server",
            //    Children = new string[] {
            //   "Proxy Server1",
            //   "Proxy Server2",
            //   "Proxy Server3",
            //   "Proxy Server4",
            //   "Proxy Server5"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes147);
            //Node NetworkShapes148 = new Node()
            //{
            //    ID = "Rack Server1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M45.3357955,34.234375 C45.2753984,34.2446492 45.2133241,34.25 45.15,34.25 L5.1,34.25 C5.03667593,34.25 4.97460161,34.2446492 4.91420452,34.234375 L2.088125,34.234375 C1.3042212,34.0082788 1.3042212,34.0082788 1.078125,33.224375 L1.078125,28.931875 C1.3042212,28.1479712 1.3042212,28.1479712 2.088125,27.921875 L4,27.921875 L4,21.3125 L2.01,21.3125 C1.2260962,21.0864038 1.2260962,21.0864038 1,20.3025 L1,16.01 C1.2260962,15.2260962 1.2260962,15.2260962 2.01,15 L5.1,15 L45.15,15 C45.1520847,15 45.154168,15.0000058 45.15625,15.0000174 L48.3025,15 C49.0864038,15.2260962 49.0864038,15.2260962 49.3125,16.01 L49.3125,20.3025 C49.0864038,21.0864038 49.0864038,21.0864038 48.3025,21.3125 L46.25,21.3125 L46.25,27.921875 L48.224375,27.921875 C49.0082788,28.1479712 49.0082788,28.1479712 49.234375,28.931875 L49.234375,33.224375 C49.0082788,34.0082788 49.0082788,34.0082788 48.224375,34.234375 L45.3357955,34.234375 Z"
            //    },
            //    Width = 48.3125,
            //    Height = 19.25,
            //    OffsetX = 25.15625,
            //    OffsetY = 24.625,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes148);
            //Node NetworkShapes149 = new Node()
            //{
            //    ID = "Rack Server2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M6,32.25 L6,17 L44.25,17 L44.25,32.25 L6,32.25 Z M7.75,26.0625 L7.75,30.375 L16.375,30.375 L16.375,26.0625 L7.75,26.0625 Z M7.75,20.3125 L7.75,24.625 L16.375,24.625 L16.375,20.3125 L7.75,20.3125 Z M17.8125,20.3125 L17.8125,24.625 L26.4375,24.625 L26.4375,20.3125 L17.8125,20.3125 Z M27.875,20.3125 L27.875,24.625 L36.5,24.625 L36.5,20.3125 L27.875,20.3125 Z M17.8125,26.0625 L17.8125,30.375 L26.4375,30.375 L26.4375,26.0625 L17.8125,26.0625 Z M27.875,26.0625 L27.875,30.375 L36.5,30.375 L36.5,26.0625 L27.875,26.0625 Z M37.9375,27.5 L37.9375,28.9375 L42.25,28.9375 L42.25,27.5 L37.9375,27.5 Z M40.093399,24.4422226 C41.1634508,24.4422226 42.030899,23.5747743 42.030899,22.5047226 C42.030899,21.4346709 41.1634508,20.5672226 40.093399,20.5672226 C39.0233473,20.5672226 38.155899,21.4346709 38.155899,22.5047226 C38.155899,23.5747743 39.0233473,24.4422226 40.093399,24.4422226 Z M40.093399,23.4422226 C39.5756321,23.4422226 39.155899,23.0224895 39.155899,22.5047226 C39.155899,21.9869556 39.5756321,21.5672226 40.093399,21.5672226 C40.611166,21.5672226 41.030899,21.9869556 41.030899,22.5047226 C41.030899,23.0224895 40.611166,23.4422226 40.093399,23.4422226 Z"
            //    },
            //    Width = 38.25,
            //    Height = 15.25,
            //    OffsetX = 25.125,
            //    OffsetY = 24.625,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes149);
            //Node NetworkShapes150 = new Node()
            //{
            //    ID = "Rack Server3",
            //    Shape = new BasicShape()
            //    {
            //        Type = Shapes.Basic,
            //        Shape = BasicShapeType.Rectangle
            //    },
            //    Width = 5.75,
            //    Height = 1.4375,
            //    OffsetX = 12.0625,
            //    OffsetY = 22.46875,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes150);
            //Node NetworkShapes151 = new Node()
            //{
            //    ID = "Rack Server4",
            //    Shape = new BasicShape()
            //    {
            //        Type = Shapes.Basic,
            //        Shape = BasicShapeType.Rectangle
            //    },
            //    Width = 5.75,
            //    Height = 1.4375,
            //    OffsetX = 12.0625,
            //    OffsetY = 28.21875,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes151);
            //Node NetworkShapes152 = new Node()
            //{
            //    ID = "Rack Server5",
            //    Shape = new BasicShape()
            //    {
            //        Type = Shapes.Basic,
            //        Shape = BasicShapeType.Rectangle
            //    },
            //    Width = 5.75,
            //    Height = 1.4375,
            //    OffsetX = 22.125,
            //    OffsetY = 22.46875,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes152);
            //Node NetworkShapes153 = new Node()
            //{
            //    ID = "Rack Server6",
            //    Shape = new BasicShape()
            //    {
            //        Type = Shapes.Basic,
            //        Shape = BasicShapeType.Rectangle
            //    },
            //    Width = 5.75,
            //    Height = 1.4375,
            //    OffsetX = 32.1875,
            //    OffsetY = 22.46875,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes153);
            //Node NetworkShapes154 = new Node()
            //{
            //    ID = "Rack Server7",
            //    Shape = new BasicShape()
            //    {
            //        Type = Shapes.Basic,
            //        Shape = BasicShapeType.Rectangle
            //    },
            //    Width = 5.75,
            //    Height = 1.4375,
            //    OffsetX = 22.125,
            //    OffsetY = 28.21875,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes154);
            //Node NetworkShapes155 = new Node()
            //{
            //    ID = "Rack Server8",
            //    Shape = new BasicShape()
            //    {
            //        Type = Shapes.Basic,
            //        Shape = BasicShapeType.Rectangle
            //    },
            //    Width = 5.75,
            //    Height = 1.4375,
            //    OffsetX = 32.1875,
            //    OffsetY = 28.21875,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes155);
            //NodeGroup NetworkShapes156 = new NodeGroup()
            //{
            //    ID = "Rack Server",
            //    Children = new string[] {
            //   "Rack Server1",
            //   "Rack Server2",
            //   "Rack Server3",
            //   "Rack Server4",
            //   "Rack Server5",
            //   "Rack Server6",
            //   "Rack Server7",
            //   "Rack Server8"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes156);
            //Node NetworkShapes157 = new Node()
            //{
            //    ID = "Rack Server9",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M2.1,38 C1.49248678,38 1,37.5075132 1,36.9 L1,14.1 C1,13.4924868 1.49248678,13 2.1,13 L47.9,13 C48.5075132,13 49,13.4924868 49,14.1 L49,36.9 C49,37.5075132 48.5075132,38 47.9,38 L2.1,38 Z"
            //    },
            //    Width = 48,
            //    Height = 25,
            //    OffsetX = 25,
            //    OffsetY = 25.5,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes157);
            //Node NetworkShapes158 = new Node()
            //{
            //    ID = "Rack Server10",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M3,36 L3,15 L47,15 L47,36 L3,36 Z M6.4125,32.6875 L23.4625,32.6875 C23.5177285,32.6875 23.5625,32.6427285 23.5625,32.5875 L23.5625,18.4125 C23.5625,18.3572715 23.5177285,18.3125 23.4625,18.3125 L6.4125,18.3125 C6.35727153,18.3125 6.3125,18.3572715 6.3125,18.4125 L6.3125,32.5875 C6.3125,32.6427285 6.35727153,32.6875 6.4125,32.6875 Z M26.5375,32.6875 L43.5875,32.6875 C43.6427285,32.6875 43.6875,32.6427285 43.6875,32.5875 L43.6875,18.4125 C43.6875,18.3572715 43.6427285,18.3125 43.5875,18.3125 L26.5375,18.3125 C26.4822715,18.3125 26.4375,18.3572715 26.4375,18.4125 L26.4375,32.5875 C26.4375,32.6427285 26.4822715,32.6875 26.5375,32.6875 Z"
            //    },
            //    Width = 44,
            //    Height = 21,
            //    OffsetX = 25,
            //    OffsetY = 25.5,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes158);
            //Node NetworkShapes159 = new Node()
            //{
            //    ID = "Rack Server11",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M9.1875,21.1875 L19.25,21.1875 L19.25,24.0625 L9.1875,24.0625 L9.1875,21.1875 Z M29.3125,21.1875 L39.375,21.1875 L39.375,24.0625 L29.3125,24.0625 L29.3125,21.1875 Z M9.1875,26.9375 L19.25,26.9375 L19.25,29.8125 L9.1875,29.8125 L9.1875,26.9375 Z M29.3125,26.9375 L39.375,26.9375 L39.375,29.8125 L29.3125,29.8125 L29.3125,26.9375 Z"
            //    },
            //    Width = 30.1875,
            //    Height = 8.625,
            //    OffsetX = 24.28125,
            //    OffsetY = 25.5,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes159);
            //NodeGroup NetworkShapes160 = new NodeGroup()
            //{
            //    ID = "Rack Server12",
            //    Children = new string[] {
            //   "Rack Server9",
            //   "Rack Server10",
            //   "Rack Server11"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes160);
            //Node NetworkShapes161 = new Node()
            //{
            //    ID = "Rack1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M13.9370635,12.6954485 L13.9370635,37.1954485 L36.5,37.1954485 L36.5,12.6954485 L13.9370635,12.6954485 Z M2.4375,10.6957245 L2.4375,4 C2.4375,2.8954305 3.3329305,2 4.4375,2 L45.5625,2 C46.6670695,2 47.5625,2.8954305 47.5625,4 L47.5625,10.7016591 L47.5658594,10.7016591 L47.5658594,38.5111051 L47.5642462,38.5111051 L47.5642462,45.8908971 C47.5642462,46.9954666 46.6688157,47.8908971 45.5642462,47.8908971 L4.43924615,47.8908971 C3.33467665,47.8908971 2.43924615,46.9954666 2.43924615,45.8908971 L2.43924615,38.4851805 L2.43706348,38.4851805 L2.43706348,10.6957245 Z"
            //    },
            //    Width = 45.1287956237793,
            //    Height = 45.89089584350586,
            //    OffsetX = 25.001461267471313,
            //    OffsetY = 24.94544792175293,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes161);
            //Node NetworkShapes162 = new Node()
            //{
            //    ID = "Rack2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M45.5625,10.6954485 L4.4375,10.6954485 L4.4375,4 L45.5625,4 L45.5625,10.6954485 Z M45.5779787,45.8096388 L4.4529787,45.8096388 L4.4529787,39.1141902 L45.5779787,39.1141902 L45.5779787,45.8096388 Z M4.43706348,12.6957245 L11.9370635,12.6957245 L11.9370635,37.2356451 L4.43706348,37.2356451 L4.43706348,12.6957245 Z M8.08959714,17.375 C8.88350646,17.375 9.5,16.7314093 9.5,15.9375 C9.5,15.1435907 8.88350646,14.5 8.08959714,14.5 C7.29568781,14.5 6.65209714,15.1435907 6.65209714,15.9375 C6.65209714,16.7314093 7.29568781,17.375 8.08959714,17.375 Z M8.06328282,21.6875 C8.85719215,21.6875 9.50078282,21.0439093 9.50078282,20.25 C9.50078282,19.4560907 8.85719215,18.8125 8.06328282,18.8125 C7.26937349,18.8125 6.62578282,19.4560907 6.62578282,20.25 C6.62578282,21.0439093 7.26937349,21.6875 8.06328282,21.6875 Z M8.05811896,26 C8.85202828,26 9.49561896,25.3564093 9.49561896,24.5625 C9.49561896,23.7685907 8.85202828,23.125 8.05811896,23.125 C7.26420963,23.125 6.62061896,23.7685907 6.62061896,24.5625 C6.62061896,25.3564093 7.26420963,26 8.05811896,26 Z M8.0583235,30.3125 C8.85223282,30.3125 9.4958235,29.6689093 9.4958235,28.875 C9.4958235,28.0810907 8.85223282,27.4375 8.0583235,27.4375 C7.26441417,27.4375 6.6208235,28.0810907 6.6208235,28.875 C6.6208235,29.6689093 7.26441417,30.3125 8.0583235,30.3125 Z M8.06681194,34.625 C8.86072127,34.625 9.50431194,33.9814093 9.50431194,33.1875 C9.50431194,32.3935907 8.86072127,31.75 8.06681194,31.75 C7.27290262,31.75 6.62931194,32.3935907 6.62931194,33.1875 C6.62931194,33.9814093 7.27290262,34.625 8.06681194,34.625 Z M38.5,37.2346584 L38.5,12.7016591 L45.5658594,12.7016591 L45.5658594,37.2346584 L38.5,37.2346584 Z M42.25,17.375 C43.0439093,17.375 43.6875,16.7314093 43.6875,15.9375 C43.6875,15.1435907 43.0439093,14.5 42.25,14.5 C41.4560907,14.5 40.8125,15.1435907 40.8125,15.9375 C40.8125,16.7314093 41.4560907,17.375 42.25,17.375 Z M42.25,21.6875 C43.0439093,21.6875 43.6875,21.0439093 43.6875,20.25 C43.6875,19.4560907 43.0439093,18.8125 42.25,18.8125 C41.4560907,18.8125 40.8125,19.4560907 40.8125,20.25 C40.8125,21.0439093 41.4560907,21.6875 42.25,21.6875 Z M42.25,26 C43.0439093,26 43.6875,25.3564093 43.6875,24.5625 C43.6875,23.7685907 43.0439093,23.125 42.25,23.125 C41.4560907,23.125 40.8125,23.7685907 40.8125,24.5625 C40.8125,25.3564093 41.4560907,26 42.25,26 Z M42.25,30.3125 C43.0439093,30.3125 43.6875,29.6689093 43.6875,28.875 C43.6875,28.0810907 43.0439093,27.4375 42.25,27.4375 C41.4560907,27.4375 40.8125,28.0810907 40.8125,28.875 C40.8125,29.6689093 41.4560907,30.3125 42.25,30.3125 Z M42.25,34.625 C43.0439093,34.625 43.6875,33.9814093 43.6875,33.1875 C43.6875,32.3935907 43.0439093,31.75 42.25,31.75 C41.4560907,31.75 40.8125,32.3935907 40.8125,33.1875 C40.8125,33.9814093 41.4560907,34.625 42.25,34.625 Z"
            //    },
            //    Width = 41.14091491699219,
            //    Height = 41.80963897705078,
            //    OffsetX = 25.007521152496338,
            //    OffsetY = 24.90481948852539,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes162);
            //Node NetworkShapes163 = new Node()
            //{
            //    ID = "Rack3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M13.9400861 12.6961017 36.4994368 12.6961017 36.4994368 37.1980087 13.9400861 37.1980087"
            //    },
            //    Width = 22.559349060058594,
            //    Height = 24.501907348632812,
            //    OffsetX = 25.21976089477539,
            //    OffsetY = 24.94705581665039,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes163);
            //NodeGroup NetworkShapes164 = new NodeGroup()
            //{
            //    ID = "Rack",
            //    Children = new string[] {
            //   "Rack1",
            //   "Rack2",
            //   "Rack3"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes164);
            //Node NetworkShapes165 = new Node()
            //{
            //    ID = "Router1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M7.5,23 L7.5,16.8298408 C6.33360465,16.4183195 5.4986485,15.3062187 5.4986485,14 C5.4986485,12.344 6.8406485,11 8.4986485,11 C10.1546485,11 11.4986485,12.344 11.4986485,14 C11.4986485,15.3049145 10.664117,16.4160985 9.5,16.828606 L9.5,23 L46.9,23 C47.5075132,23 48,23.4924868 48,24.1 L48,40.9 C48,41.5075132 47.5075132,42 46.9,42 L43,42 L43,43.99 C42.7739038,44.7739038 42.7739038,44.7739038 41.99,45 L35.01,45 C34.2260962,44.7739038 34.2260962,44.7739038 34,43.99 L34,42 L17,42 L17,43.99 C16.7739038,44.7739038 16.7739038,44.7739038 15.99,45 L9.01,45 C8.2260962,44.7739038 8.2260962,44.7739038 8,43.99 L8,42 L3.1,42 C2.49248678,42 2,41.5075132 2,40.9 L2,24.1 C2,23.4924868 2.49248678,23 3.1,23 L7.5,23 Z M12,6 C15.3911466,6.48560201 18,9.4041312 18,12.9290274 C18,16.3208153 15.5844593,19.1511671 12.380728,19.7927328 C12.2549998,19.8179106 12.1280577,19.8397174 12,19.8580549 L12,17.0090333 C12.1277796,16.9777742 12.2532736,16.9406618 12.3761813,16.897997 C14.0191788,16.3276646 15.2,14.7651265 15.2,12.9290274 C15.2,10.9555754 13.8359035,9.29814366 12,8.84902162 L12,6 Z M15,43 L15,42 L10,42 L10,43 L15,43 Z M41,43 L41,42 L36,42 L36,43 L41,43 Z"
            //    },
            //    Width = 46,
            //    Height = 39,
            //    OffsetX = 25,
            //    OffsetY = 25.5,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes165);
            //Node NetworkShapes166 = new Node()
            //{
            //    ID = "Router2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M4,40 L4,25 L46,25 L46,40 L4,40 Z M35,32.5 C35,31.672 34.328,31 33.5,31 C32.671,31 32,31.672 32,32.5 C32,33.328 32.671,34 33.5,34 C34.328,34 35,33.328 35,32.5 Z M39,32.5 C39,31.672 38.328,31 37.5,31 C36.671,31 36,31.672 36,32.5 C36,33.328 36.671,34 37.5,34 C38.328,34 39,33.328 39,32.5 Z M10,32.5 C10,31.672 9.328,31 8.5,31 C7.671,31 7,31.672 7,32.5 C7,33.328 7.671,34 8.5,34 C9.328,34 10,33.328 10,32.5 Z M43,32.5 C43,31.672 42.328,31 41.5,31 C40.671,31 40,31.672 40,32.5 C40,33.328 40.671,34 41.5,34 C42.328,34 43,33.328 43,32.5 Z"
            //    },
            //    Width = 42,
            //    Height = 15,
            //    OffsetX = 25,
            //    OffsetY = 32.5,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes166);
            //Node NetworkShapes167 = new Node()
            //{
            //    ID = "Router3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M13 33.5 13 31.5 28 31.5 28 33.5"
            //    },
            //    Width = 15,
            //    Height = 2,
            //    OffsetX = 20.5,
            //    OffsetY = 32.5,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes167);
            //Node NetworkShapes168 = new Node()
            //{
            //    ID = "Router4",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M35,32.5 C35,33.328 34.328,34 33.5,34 C32.671,34 32,33.328 32,32.5 C32,31.672 32.671,31 33.5,31 C34.328,31 35,31.672 35,32.5"
            //    },
            //    Width = 3,
            //    Height = 3,
            //    OffsetX = 33.5,
            //    OffsetY = 32.5,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes168);
            //Node NetworkShapes169 = new Node()
            //{
            //    ID = "Router5",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M39,32.5 C39,33.328 38.328,34 37.5,34 C36.671,34 36,33.328 36,32.5 C36,31.672 36.671,31 37.5,31 C38.328,31 39,31.672 39,32.5"
            //    },
            //    Width = 3,
            //    Height = 3,
            //    OffsetX = 37.5,
            //    OffsetY = 32.5,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes169);
            //NodeGroup NetworkShapes170 = new NodeGroup()
            //{
            //    ID = "Router",
            //    Children = new string[] {
            //   "Router1",
            //   "Router2",
            //   "Router3",
            //   "Router3",
            //   "Router4",
            //   "Router5"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes170);
            //Node NetworkShapes171 = new Node()
            //{
            //    ID = "SatelliteAntenna1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M22.2216279,18.3610907 C22.0149448,17.8997116 21.9,17.3882792 21.9,16.85 C21.9,14.8065464 23.5565464,13.15 25.6,13.15 C27.6434536,13.15 29.3,14.8065464 29.3,16.85 C29.3,18.8934536 27.6434536,20.55 25.6,20.55 C25.114036,20.55 24.6499538,20.4563124 24.2248301,20.2860135 L21.86334,26.6918003 L29.9314848,34.759945 L29.156451,35.4654579 C26.2980126,38.0674929 22.5795814,39.5354629 18.6347826,39.5354629 C16.507034,39.5354629 14.4785577,39.1104281 12.629626,38.3406308 L18.9001978,46.5620266 C18.9336911,46.6059399 18.925244,46.6686904 18.8813306,46.7021838 C18.8639065,46.7154734 18.8425994,46.7226716 18.8206856,46.7226716 L2.82217255,46.7226716 C2.76694408,46.7226716 2.72217255,46.6779001 2.72217255,46.6226716 C2.72217255,46.6003098 2.72966771,46.5785932 2.74346046,46.5609917 L10.1885698,37.0599958 C5.86428343,34.2787335 3,29.4242015 3,23.9006803 C3,19.9558816 4.46797004,16.2374503 7.07000507,13.3790119 L7.77551793,12.6039782 L15.7296827,20.5581429 L22.2216279,18.3610907 Z M17.3072273,22.1356876 L20.305911,25.1343712 L21.9964006,20.5487428 L17.3072273,22.1356876 Z M25.6,18.55 C26.5388841,18.55 27.3,17.7888841 27.3,16.85 C27.3,15.9111159 26.5388841,15.15 25.6,15.15 C24.6611159,15.15 23.9,15.9111159 23.9,16.85 C23.9,17.7888841 24.6611159,18.55 25.6,18.55 Z M26.8742277,11.0971251 C26.3235306,11.0552772 25.9110269,10.5749247 25.9528749,10.0242277 C25.9947228,9.47353064 26.4750753,9.06102695 27.0257723,9.10287486 C30.8032018,9.38992478 32.9374665,11.5241885 33.1591839,15.2515675 C33.1919777,15.8028778 32.7716371,16.2763877 32.2203269,16.3091816 C31.6690166,16.3419754 31.1955067,15.9216348 31.1627128,15.3703245 C31.0008154,12.6486032 29.6611145,11.3089029 26.8742277,11.0971251 Z M28.2570686,7.04907802 C27.7052931,7.02536769 27.2772116,6.5588442 27.300922,6.00706864 C27.3246323,5.45529309 27.7911558,5.02721164 28.3429314,5.05092198 C33.9376552,5.2913327 36.9997198,8.40276256 37.2506696,14.0857208 C37.2750338,14.6374679 36.8475056,15.1044983 36.2957585,15.1288626 C35.7440114,15.1532268 35.2769809,14.7256985 35.2526167,14.1739514 C35.0470958,9.51976631 32.8080649,7.24463876 28.2570686,7.04907802 Z M29.5983572,2.99866562 C29.0468094,2.97014412 28.6228129,2.49990504 28.6513344,1.94835724 C28.6798559,1.39680945 29.150095,0.97281287 29.7016428,1.00133438 C37.2518221,1.39176744 41.3267258,5.44714899 41.6326059,12.8897659 C41.6552848,13.4415848 41.2263321,13.9073073 40.6745132,13.9299862 C40.1226943,13.9526651 39.6569718,13.5237124 39.6342929,12.9718934 C39.3711003,6.56794102 36.1237044,3.33610281 29.5983572,2.99866562 Z"
            //    },
            //    Width = 38.911293029785156,
            //    Height = 45.722694396972656,
            //    OffsetX = 22.17781901359558,
            //    OffsetY = 23.861322939395905,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes171);
            //Node NetworkShapes172 = new Node()
            //{
            //    ID = "SatelliteAntenna2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M5,23.9006803 C5,20.817505 6.02628705,17.8965345 7.87185085,15.5287382 L27.0067247,34.6636121 C24.6389284,36.5091759 21.717958,37.5354629 18.6347826,37.5354629 C11.1045001,37.5354629 5,31.4309628 5,23.9006803 Z M10.8796284,39.3828843 L14.9523577,44.7226716 L6.69529867,44.7226716 L10.8796284,39.3828843 Z"
            //    },
            //    Width = 22.006725311279297,
            //    Height = 29.193933486938477,
            //    OffsetX = 16.00336265563965,
            //    OffsetY = 30.125704765319824,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes172);
            //NodeGroup NetworkShapes173 = new NodeGroup()
            //{
            //    ID = "Satellite Antenna",
            //    Children = new string[] {
            //   "SatelliteAntenna1",
            //   "SatelliteAntenna2"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes173);
            //Node NetworkShapes174 = new Node()
            //{
            //    ID = "Satellite1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M29.3909966,20.7964946 L31.9530092,22.2756733 L33.6477685,19.0882948 C33.6736967,19.0395309 33.7342465,19.021019 33.7830104,19.0469472 L46.7467586,25.9398943 C46.7955224,25.9658225 46.8140344,26.0263724 46.7881062,26.0751363 L42.4358286,34.2605798 C42.4099004,34.3093437 42.3493506,34.3278556 42.3005867,34.3019274 L29.3368385,27.4089802 C29.2880747,27.383052 29.2695627,27.3225022 29.2954909,27.2737383 L30.6819001,24.6662819 L28.0380554,23.1398575 L23.2583302,31.4185843 L21.1311746,30.1904704 C21.1296972,30.1938399 21.1280192,30.1971623 21.1261368,30.2004228 C21.1255569,30.2014272 21.1249596,30.2024215 21.1243451,30.2034051 L19.3626573,33.0234106 C23.2836816,36.0962251 24.9558146,39.427382 24.2249084,42.998446 L24.2142465,43.0474118 C24.0849936,43.641016 23.4990022,44.0174472 22.9053979,43.8881944 C22.741105,43.843416 22.741105,43.843416 22.5894316,43.7660071 L17.3583519,40.7458471 L12.779321,42.5086867 C12.4692569,42.6280554 12.1218522,42.6008842 11.8341171,42.4347602 L9.84243216,41.2848604 C9.5576357,41.1204331 9.36134343,40.8372091 9.30735635,40.5128162 L8.49444718,35.6282782 L2.97407263,32.441094 C2.4479426,32.1373327 2.26767714,31.4645728 2.57143845,30.9384428 C2.69028121,30.7604244 2.69028121,30.7604244 2.8506506,30.6186647 C5.86448106,28.2852125 9.43029024,27.9494263 13.4566271,29.544762 L15.2688541,26.8115769 C15.2697747,26.8101884 15.2707244,26.8088301 15.2717018,26.8075022 L12.7131974,25.330349 L17.4929225,17.0516222 L15.3393176,15.8082378 L13.2637563,19.1298302 C13.2344897,19.1766666 13.172796,19.1909097 13.1259596,19.161643 L0.674618132,11.3811814 C0.627781728,11.3519147 0.613538616,11.290221 0.642805248,11.2433846 L5.55546854,3.38147993 C5.58473518,3.33464353 5.64642888,3.32040041 5.69326528,3.34966705 L18.1446067,11.1301287 C18.1914431,11.1593953 18.2056863,11.221089 18.1764196,11.2679254 L16.7740908,13.5121207 L18.8458637,14.7082593 L24.2131974,5.41176471 L25.7068819,6.27414384 L27.7056766,2.89908892 C27.9048702,2.56274172 28.267602,2.35737568 28.6585015,2.35963298 L31.5344005,2.37624024 C31.7253341,2.37734281 31.9126925,2.42812561 32.0780485,2.52359396 L33.4058269,3.29018714 C33.571067,3.38558859 33.7086504,3.5223307 33.8050636,3.68698261 L35.2588529,6.16972735 C35.4586512,6.51093783 35.4599459,6.93313032 35.2622441,7.27555982 L33.3070294,10.6620911 L34.7583302,11.5 L29.3909966,20.7964946 Z M17.6136641,28.1596347 C17.6121866,28.1630042 17.6105086,28.1663267 17.6086262,28.1695871 C17.6075946,28.171374 17.6065079,28.1731285 17.6053677,28.1748481 L15.9139371,30.725849 C16.3129645,30.9498563 16.7159732,31.1911256 17.1228851,31.4496002 C17.131096,31.4548159 17.1393002,31.4600323 17.1474975,31.4652496 L18.7846705,28.8445599 C18.7860382,28.8423706 18.7874773,28.840252 18.7889828,28.8382053 L17.6136641,28.1596347 Z M15.1313704,39.460101 L10.7374776,36.9232902 L11.2104572,39.765289 L12.4618859,40.4878016 L15.1313704,39.460101 Z M27.4390391,7.27420528 L31.5749786,9.66209107 L33.2685424,6.72875249 L32.1995409,4.90313869 L31.2844841,4.37483041 L29.1633778,4.3625818 L27.4390391,7.27420528 Z M11.6220128,46.4691309 L5.93681073,43.1867779 C5.88898147,43.1591637 5.87259396,43.0980047 5.90020819,43.0501754 L6.47667878,42.0516991 C6.50429302,42.0038698 6.56545206,41.9874823 6.61328132,42.0150965 L12.2984834,45.2974495 C12.3463126,45.3250637 12.3627002,45.3862227 12.3350859,45.434052 L11.7586153,46.4325283 C11.7310011,46.4803576 11.6698421,46.4967451 11.6220128,46.4691309 Z"
            //    },
            //    Width = 46.17223358154297,
            //    Height = 44.122928619384766,
            //    OffsetX = 23.713713467121124,
            //    OffsetY = 24.42107892036438,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes174);
            //Node NetworkShapes175 = new Node()
            //{
            //    ID = "Satellite2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M6.24471814,6.05260984 L15.4734768,11.8193783 L12.5745067,16.4587002 L3.34574804,10.6919318 L6.24471814,6.05260984 Z M10.0481712,12.505561 C10.0950076,12.5348276 10.1567013,12.5205845 10.1859679,12.4737481 L10.7969337,11.4959985 C10.8262003,11.4491621 10.8119572,11.3874684 10.7651208,11.3582018 L6.34529365,8.59638728 C6.29845725,8.56712064 6.23676355,8.58136376 6.20749692,8.62820016 L5.59653118,9.60594973 C5.56726455,9.65278613 5.58150766,9.71447983 5.62834406,9.74374647 L10.0481712,12.505561 Z M31.9533821,26.535081 L34.5216677,21.7048383 L44.130215,26.8137936 L41.5619294,31.6440363 L31.9533821,26.535081 Z M41.379222,29.2205618 C41.4275259,29.2473371 41.4883896,29.2298847 41.5151649,29.1815808 L42.0741219,28.1731957 C42.1008972,28.1248918 42.0834448,28.064028 42.0351409,28.0372527 L37.4768287,25.5105391 C37.4285248,25.4837638 37.3676611,25.5012162 37.3408858,25.5495201 L36.7819288,26.5579052 C36.7551535,26.6062091 36.7726059,26.6670728 36.8209098,26.6938481 L41.379222,29.2205618 Z M32.0262794,12.2320508 L22.5262794,28.6865335 L15.4452482,24.5982982 L24.9452482,8.14381551 L32.0262794,12.2320508 Z M5.61922696,31.6595183 C8.55814511,30.0844871 12.116404,30.6175551 16.4290923,33.3570192 C20.680386,36.0574848 22.7392504,38.7827196 22.7681543,41.5604561 L5.61922696,31.6595183 Z"
            //    },
            //    Width = 40.78446578979492,
            //    Height = 35.50784683227539,
            //    OffsetX = 23.737980842590332,
            //    OffsetY = 23.806533336639404,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes175);
            //NodeGroup NetworkShapes176 = new NodeGroup()
            //{
            //    ID = "Satellite",
            //    Children = new string[] {
            //   "Satellite1",
            //   "Satellite2"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes176);
            //Node NetworkShapes177 = new Node()
            //{
            //    ID = "Scanner1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M3.8794843,41.8125 C3.87651626,41.7795638 3.875,41.746209 3.875,41.7125 L3.875,30.4125 C3.875,29.8049868 4.36748678,29.3125 4.975,29.3125 L46,29.3125 C47.6568542,29.3125 49,30.6556458 49,32.3125 L49,41.7125 C49,42.3200132 48.5075132,42.8125 47.9,42.8125 L44.6875,42.8125 L44.6875,46.025 C44.6875,46.6325132 44.1950132,47.125 43.5875,47.125 L4.975,47.125 C4.36748678,47.125 3.875,46.6325132 3.875,46.025 L3.875,41.9125 C3.875,41.878791 3.87651626,41.8454362 3.8794843,41.8125 Z M5.55355477,28.4792854 C5.02743289,28.783042 4.35468344,28.6027793 4.05092683,28.0766574 L1.99467683,24.5151279 C1.69092021,23.9890061 1.87118289,23.3162566 2.39730477,23.0125 L37.925997,2.5 C39.3608748,1.67157288 41.195646,2.16319834 42.0240732,3.59807621 L43.1303232,5.51415742 C43.4340798,6.0402793 43.2538171,6.71302875 42.7276952,7.01678536 L5.55355477,28.4792854 Z"
            //    },
            //    Width = 47.15287780761719,
            //    Height = 45.02742385864258,
            //    OffsetX = 25.4235600233078,
            //    OffsetY = 24.611287117004395,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes177);
            //Node NetworkShapes178 = new Node()
            //{
            //    ID = "Scanner2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M42.25,36.0625 C42.25,36.856 41.606,37.5 40.8125,37.5 C40.0180417,37.5 39.375,36.856 39.375,36.0625 C39.375,35.269 40.0180417,34.625 40.8125,34.625 C41.606,34.625 42.25,35.269 42.25,36.0625"
            //    },
            //    Width = 2.875,
            //    Height = 2.875,
            //    OffsetX = 40.8125,
            //    OffsetY = 36.0625,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes178);
            //Node NetworkShapes179 = new Node()
            //{
            //    ID = "Scanner3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M36.5,36.0625 C36.5,36.856 35.856,37.5 35.0625,37.5 C34.2680417,37.5 33.625,36.856 33.625,36.0625 C33.625,35.269 34.2680417,34.625 35.0625,34.625 C35.856,34.625 36.5,35.269 36.5,36.0625"
            //    },
            //    Width = 2.875,
            //    Height = 2.875,
            //    OffsetX = 35.0625,
            //    OffsetY = 36.0625,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes179);
            //Node NetworkShapes180 = new Node()
            //{
            //    ID = "Scanner4",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M5.875,40.8125 L5.875,31.3125 L46,31.3125 C46.5522847,31.3125 47,31.7602153 47,32.3125 L47,40.8125 L5.875,40.8125 Z M41.098098,5.65159593 L5.4828033,26.2140959 L4.3265533,24.2114122 L39.0758226,4.14891218 C39.5541153,3.87276981 40.1657057,4.03664497 40.441848,4.51493759 L41.098098,5.65159593 Z M5.875,45.125 L5.875,42.8125 L42.6875,42.8125 L42.6875,45.125 L5.875,45.125 Z"
            //    },
            //    Width = 42.67344665527344,
            //    Height = 41.1102294921875,
            //    OffsetX = 25.66327667236328,
            //    OffsetY = 24.56988525390625,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes180);
            //NodeGroup NetworkShapes181 = new NodeGroup()
            //{
            //    ID = "Scanner",
            //    Children = new string[] {
            //   "Scanner1",
            //   "Scanner2",
            //   "Scanner3",
            //   "Scanner4"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes181);
            //Node NetworkShapes182 = new Node()
            //{
            //    ID = "Securitycamera1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M43.6875,15.625 L43.6875,24.6875 C43.6875,35.0083213 35.3208213,43.375 25,43.375 C14.6791787,43.375 6.3125,35.0083213 6.3125,24.6875 L6.3125,15.625 L6,15.625 C3.23857625,15.625 1,13.3864237 1,10.625 L1,6.1 C1,5.49248678 1.49248678,5 2.1,5 L47.9,5 C48.5075132,5 49,5.49248678 49,6.1 L49,10.625 C49,13.3864237 46.7614237,15.625 44,15.625 L43.6875,15.625 Z"
            //    },
            //    Width = 48,
            //    Height = 38.375,
            //    OffsetX = 25,
            //    OffsetY = 24.1875,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes182);
            //Node NetworkShapes183 = new Node()
            //{
            //    ID = "Securitycamera2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M36.5,36.7798012 L36.5,32.8313446 C36.5,26.48007 31.3512746,21.3313446 25,21.3313446 C18.6487254,21.3313446 13.5,26.48007 13.5,32.8313446 L13.5,36.7798012 C10.304434,33.7398098 8.3125,29.4462755 8.3125,24.6875 L8.3125,15.9269929 L41.6875,15.9269929 L41.6875,24.6875 C41.6875,29.4462755 39.695566,33.7398098 36.5,36.7798012 Z M25.6271042,41.1970624 C21.9788942,41.3644097 18.6230961,40.3941169 15.5,38.2583576 L15.5,32.8313446 C15.5,27.5846395 19.7532949,23.3313446 25,23.3313446 C30.2467051,23.3313446 34.5,27.5846395 34.5,32.8313446 L34.5,38.1751024 C32.1311893,40.0249544 29.1938027,41.0334541 25.6271042,41.1970624 Z M25,38.625 C27.9340127,38.625 30.3125,36.2465127 30.3125,33.3125 C30.3125,30.3784873 27.9340127,28 25,28 C22.0659873,28 19.6875,30.3784873 19.6875,33.3125 C19.6875,36.2465127 22.0659873,38.625 25,38.625 Z M25,36.4468665 C23.3431458,36.4468665 22,35.1037208 22,33.4468665 C22,31.7900123 23.3431458,30.4468665 25,30.4468665 C26.6568542,30.4468665 28,31.7900123 28,33.4468665 C28,35.1037208 26.6568542,36.4468665 25,36.4468665 Z M3,7 L47,7 L47,10.625 C47,12.2818542 45.6568542,13.625 44,13.625 L6,13.625 C4.34314575,13.625 3,12.2818542 3,10.625 L3,7 Z"
            //    },
            //    Width = 44,
            //    Height = 34.21551513671875,
            //    OffsetX = 25,
            //    OffsetY = 24.107757568359375,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes183);
            //NodeGroup NetworkShapes184 = new NodeGroup()
            //{
            //    ID = "Security Camera",
            //    Children = new string[] {
            //   "Securitycamera1",
            //   "Securitycamera2"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes184);
            //Node NetworkShapes185 = new Node()
            //{
            //    ID = "Server1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M23.7741935,45.516129 L23.7741935,38.6129032 L6,38.6129032 C4.34314575,38.6129032 3,37.2697575 3,35.6129032 L3,27.7419355 C3,26.973581 3.28885357,26.272692 3.76389349,25.7419355 C3.28885357,25.211179 3,24.5102899 3,23.7419355 L3,15.8709677 C3,15.1026133 3.28885357,14.4017242 3.76389349,13.8709677 C3.28885357,13.3402112 3,12.6393222 3,11.8709677 L3,4 C3,2.34314575 4.34314575,1 6,1 L43.5483871,1 C45.2052413,1 46.5483871,2.34314575 46.5483871,4 L46.5483871,11.8709677 C46.5483871,12.6393222 46.2595335,13.3402112 45.7844936,13.8709677 C46.2595335,14.4017242 46.5483871,15.1026133 46.5483871,15.8709677 L46.5483871,23.7419355 C46.5483871,24.5102899 46.2595335,25.211179 45.7844936,25.7419355 C46.2595335,26.272692 46.5483871,26.973581 46.5483871,27.7419355 L46.5483871,35.6129032 C46.5483871,37.2697575 45.2052413,38.6129032 43.5483871,38.6129032 L25.7741935,38.6129032 L25.7741935,45.516129 L44.0645161,45.516129 C44.6168009,45.516129 45.0645161,45.9638443 45.0645161,46.516129 C45.0645161,47.0684138 44.6168009,47.516129 44.0645161,47.516129 L5.48387097,47.516129 C4.93158622,47.516129 4.48387097,47.0684138 4.48387097,46.516129 C4.48387097,45.9638443 4.93158622,45.516129 5.48387097,45.516129 L23.7741935,45.516129 Z"
            //    },
            //    Width = 43.54838562011719,
            //    Height = 46.51612854003906,
            //    OffsetX = 24.774192810058594,
            //    OffsetY = 24.25806427001953,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes185);
            //Node NetworkShapes186 = new Node()
            //{
            //    ID = "Server2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M32.1935484,31.6774194 C32.1935484,32.4965161 31.5287742,33.1612903 30.7096774,33.1612903 C29.8895914,33.1612903 29.2258065,32.4965161 29.2258065,31.6774194 C29.2258065,30.8583226 29.8895914,30.1935484 30.7096774,30.1935484 C31.5287742,30.1935484 32.1935484,30.8583226 32.1935484,31.6774194"
            //    },
            //    Width = 2.967742919921875,
            //    Height = 2.967741012573242,
            //    OffsetX = 30.709678649902344,
            //    OffsetY = 31.67741870880127,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes186);
            //Node NetworkShapes187 = new Node()
            //{
            //    ID = "Server3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M36.6451613,31.6774194 C36.6451613,32.4965161 35.9803871,33.1612903 35.1612903,33.1612903 C34.3412043,33.1612903 33.6774194,32.4965161 33.6774194,31.6774194 C33.6774194,30.8583226 34.3412043,30.1935484 35.1612903,30.1935484 C35.9803871,30.1935484 36.6451613,30.8583226 36.6451613,31.6774194"
            //    },
            //    Width = 2.967742919921875,
            //    Height = 2.967741012573242,
            //    OffsetX = 35.16128921508789,
            //    OffsetY = 31.67741870880127,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes187);
            //Node NetworkShapes188 = new Node()
            //{
            //    ID = "Server4",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M6,36.6129032 C5.44771525,36.6129032 5,36.165188 5,35.6129032 L5,27.7419355 C5,27.1896507 5.44771525,26.7419355 6,26.7419355 L43.5483871,26.7419355 C44.1006718,26.7419355 44.5483871,27.1896507 44.5483871,27.7419355 L44.5483871,35.6129032 C44.5483871,36.165188 44.1006718,36.6129032 43.5483871,36.6129032 L6,36.6129032 Z M32.1935484,31.6774194 C32.1935484,30.8583226 31.5287742,30.1935484 30.7096774,30.1935484 C29.8895914,30.1935484 29.2258065,30.8583226 29.2258065,31.6774194 C29.2258065,32.4965161 29.8895914,33.1612903 30.7096774,33.1612903 C31.5287742,33.1612903 32.1935484,32.4965161 32.1935484,31.6774194 Z M36.6451613,31.6774194 C36.6451613,30.8583226 35.9803871,30.1935484 35.1612903,30.1935484 C34.3412043,30.1935484 33.6774194,30.8583226 33.6774194,31.6774194 C33.6774194,32.4965161 34.3412043,33.1612903 35.1612903,33.1612903 C35.9803871,33.1612903 36.6451613,32.4965161 36.6451613,31.6774194 Z M41.0967742,31.6774194 C41.0967742,30.8583226 40.432,30.1935484 39.6129032,30.1935484 C38.7928172,30.1935484 38.1290323,30.8583226 38.1290323,31.6774194 C38.1290323,32.4965161 38.7928172,33.1612903 39.6129032,33.1612903 C40.432,33.1612903 41.0967742,32.4965161 41.0967742,31.6774194 Z"
            //    },
            //    Width = 39.54838562011719,
            //    Height = 9.870967864990234,
            //    OffsetX = 24.774192810058594,
            //    OffsetY = 31.677419662475586,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes188);
            //Node NetworkShapes189 = new Node()
            //{
            //    ID = "Server5",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M6,24.7419355 C5.44771525,24.7419355 5,24.2942202 5,23.7419355 L5,15.8709677 C5,15.318683 5.44771525,14.8709677 6,14.8709677 L43.5483871,14.8709677 C44.1006718,14.8709677 44.5483871,15.318683 44.5483871,15.8709677 L44.5483871,23.7419355 C44.5483871,24.2942202 44.1006718,24.7419355 43.5483871,24.7419355 L6,24.7419355 Z M32.1935484,19.8064516 C32.1935484,18.9873548 31.5287742,18.3225806 30.7096774,18.3225806 C29.8895914,18.3225806 29.2258065,18.9873548 29.2258065,19.8064516 C29.2258065,20.6255484 29.8895914,21.2903226 30.7096774,21.2903226 C31.5287742,21.2903226 32.1935484,20.6255484 32.1935484,19.8064516 Z M36.6451613,19.8064516 C36.6451613,18.9873548 35.9803871,18.3225806 35.1612903,18.3225806 C34.3412043,18.3225806 33.6774194,18.9873548 33.6774194,19.8064516 C33.6774194,20.6255484 34.3412043,21.2903226 35.1612903,21.2903226 C35.9803871,21.2903226 36.6451613,20.6255484 36.6451613,19.8064516 Z M41.0967742,19.8064516 C41.0967742,18.9873548 40.432,18.3225806 39.6129032,18.3225806 C38.7928172,18.3225806 38.1290323,18.9873548 38.1290323,19.8064516 C38.1290323,20.6255484 38.7928172,21.2903226 39.6129032,21.2903226 C40.432,21.2903226 41.0967742,20.6255484 41.0967742,19.8064516 Z"
            //    },
            //    Width = 39.54838562011719,
            //    Height = 9.870967864990234,
            //    OffsetX = 24.774192810058594,
            //    OffsetY = 19.80645179748535,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes189);
            //Node NetworkShapes190 = new Node()
            //{
            //    ID = "Server6",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M32.1935484,19.8064516 C32.1935484,20.6255484 31.5287742,21.2903226 30.7096774,21.2903226 C29.8895914,21.2903226 29.2258065,20.6255484 29.2258065,19.8064516 C29.2258065,18.9873548 29.8895914,18.3225806 30.7096774,18.3225806 C31.5287742,18.3225806 32.1935484,18.9873548 32.1935484,19.8064516"
            //    },
            //    Width = 2.967742919921875,
            //    Height = 2.967742919921875,
            //    OffsetX = 30.709678649902344,
            //    OffsetY = 19.80645179748535,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes190);
            //Node NetworkShapes191 = new Node()
            //{
            //    ID = "Server7",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M36.6451613,19.8064516 C36.6451613,20.6255484 35.9803871,21.2903226 35.1612903,21.2903226 C34.3412043,21.2903226 33.6774194,20.6255484 33.6774194,19.8064516 C33.6774194,18.9873548 34.3412043,18.3225806 35.1612903,18.3225806 C35.9803871,18.3225806 36.6451613,18.9873548 36.6451613,19.8064516"
            //    },
            //    Width = 2.967742919921875,
            //    Height = 2.967742919921875,
            //    OffsetX = 35.16128921508789,
            //    OffsetY = 19.80645179748535,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes191);
            //Node NetworkShapes192 = new Node()
            //{
            //    ID = "Server8",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M6,12.8709677 C5.44771525,12.8709677 5,12.4232525 5,11.8709677 L5,4 C5,3.44771525 5.44771525,3 6,3 L43.5483871,3 C44.1006718,3 44.5483871,3.44771525 44.5483871,4 L44.5483871,11.8709677 C44.5483871,12.4232525 44.1006718,12.8709677 43.5483871,12.8709677 L6,12.8709677 Z M32.1935484,7.93548387 C32.1935484,7.1163871 31.5287742,6.4516129 30.7096774,6.4516129 C29.8895914,6.4516129 29.2258065,7.1163871 29.2258065,7.93548387 C29.2258065,8.75458065 29.8895914,9.41935484 30.7096774,9.41935484 C31.5287742,9.41935484 32.1935484,8.75458065 32.1935484,7.93548387 Z M36.6451613,7.93548387 C36.6451613,7.1163871 35.9803871,6.4516129 35.1612903,6.4516129 C34.3412043,6.4516129 33.6774194,7.1163871 33.6774194,7.93548387 C33.6774194,8.75458065 34.3412043,9.41935484 35.1612903,9.41935484 C35.9803871,9.41935484 36.6451613,8.75458065 36.6451613,7.93548387 Z M41.0967742,7.93548387 C41.0967742,7.1163871 40.432,6.4516129 39.6129032,6.4516129 C38.7928172,6.4516129 38.1290323,7.1163871 38.1290323,7.93548387 C38.1290323,8.75458065 38.7928172,9.41935484 39.6129032,9.41935484 C40.432,9.41935484 41.0967742,8.75458065 41.0967742,7.93548387 Z"
            //    },
            //    Width = 39.54838562011719,
            //    Height = 9.870967864990234,
            //    OffsetX = 24.774192810058594,
            //    OffsetY = 7.935483932495117,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes192);
            //Node NetworkShapes193 = new Node()
            //{
            //    ID = "Server9",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M32.1935484,7.93548387 C32.1935484,8.75458065 31.5287742,9.41935484 30.7096774,9.41935484 C29.8895914,9.41935484 29.2258065,8.75458065 29.2258065,7.93548387 C29.2258065,7.1163871 29.8895914,6.4516129 30.7096774,6.4516129 C31.5287742,6.4516129 32.1935484,7.1163871 32.1935484,7.93548387"
            //    },
            //    Width = 2.967742919921875,
            //    Height = 2.9677414894104004,
            //    OffsetX = 30.709678649902344,
            //    OffsetY = 7.935483694076538,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes193);
            //Node NetworkShapes194 = new Node()
            //{
            //    ID = "Server10",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M36.6451613,7.93548387 C36.6451613,8.75458065 35.9803871,9.41935484 35.1612903,9.41935484 C34.3412043,9.41935484 33.6774194,8.75458065 33.6774194,7.93548387 C33.6774194,7.1163871 34.3412043,6.4516129 35.1612903,6.4516129 C35.9803871,6.4516129 36.6451613,7.1163871 36.6451613,7.93548387"
            //    },
            //    Width = 2.967742919921875,
            //    Height = 2.9677414894104004,
            //    OffsetX = 35.16128921508789,
            //    OffsetY = 7.935483694076538,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes194);
            //Node NetworkShapes195 = new Node()
            //{
            //    ID = "Server11",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M8.4516129 8.93548387 8.4516129 6.93548387 24.7741935 6.93548387 24.7741935 8.93548387"
            //    },
            //    Width = 16.322580337524414,
            //    Height = 2,
            //    OffsetX = 16.612902641296387,
            //    OffsetY = 7.935483932495117,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes195);
            //Node NetworkShapes196 = new Node()
            //{
            //    ID = "Server12",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M8.4516129 20.8064516 8.4516129 18.8064516 24.7741935 18.8064516 24.7741935 20.8064516"
            //    },
            //    Width = 16.322580337524414,
            //    Height = 2,
            //    OffsetX = 16.612902641296387,
            //    OffsetY = 19.80645179748535,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes196);
            //Node NetworkShapes197 = new Node()
            //{
            //    ID = "Server13",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M8.4516129 32.6774194 8.4516129 30.6774194 24.7741935 30.6774194 24.7741935 32.6774194"
            //    },
            //    Width = 16.322580337524414,
            //    Height = 1.9999980926513672,
            //    OffsetX = 16.612902641296387,
            //    OffsetY = 31.67741870880127,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes197);
            //NodeGroup NetworkShapes198 = new NodeGroup()
            //{
            //    ID = "Server",
            //    Children = new string[] {
            //   "Server1",
            //   "Server2",
            //   "Server3",
            //   "Server4",
            //   "Server5",
            //   "Server6",
            //   "Server7",
            //   "Server8",
            //   "Server9",
            //   "Server10",
            //   "Server11",
            //   "Server12",
            //   "Server13"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes198);
            //Node NetworkShapes199 = new Node()
            //{
            //    ID = "SmartPhone1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M12,46.5882353 L12,3.41176471 C12,2.30719521 12.8954305,1.41176471 14,1.41176471 L37,1.41176471 C38.1045695,1.41176471 39,2.30719521 39,3.41176471 L39,46.5882353 C39,47.6928048 38.1045695,48.5882353 37,48.5882353 L14,48.5882353 C12.8954305,48.5882353 12,47.6928048 12,46.5882353 Z"
            //    },
            //    Width = 27,
            //    Height = 47.17646789550781,
            //    OffsetX = 25.5,
            //    OffsetY = 24.999998569488525,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes199);
            //Node NetworkShapes200 = new Node()
            //{
            //    ID = "SmartPhone2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M13.6143162 43 37.2788462 43 37.2788462 4.90950226 13.6143162 4.90950226"
            //    },
            //    Width = 23.664531707763672,
            //    Height = 38.09049606323242,
            //    OffsetX = 25.446581840515137,
            //    OffsetY = 23.954750537872314,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes200);
            //Node NetworkShapes201 = new Node()
            //{
            //    ID = "SmartPhone3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M25.8205128,47.7502519 C24.8764363,47.7502519 24.1111111,46.9723213 24.1111111,46.0126953 C24.1111111,45.0530693 24.8764363,44.2751388 25.8205128,44.2751388 C26.7645893,44.2751388 27.5299145,45.0530693 27.5299145,46.0126953 C27.5299145,46.9723213 26.7645893,47.7502519 25.8205128,47.7502519 Z M22.7922431,3.86819016 C22.5161007,3.86819016 22.2922431,3.64433254 22.2922431,3.36819016 C22.2922431,3.09204779 22.5161007,2.86819016 22.7922431,2.86819016 L28.2366877,2.86819016 C28.51283,2.86819016 28.7366877,3.09204779 28.7366877,3.36819016 C28.7366877,3.64433254 28.51283,3.86819016 28.2366877,3.86819016 L22.7922431,3.86819016 Z"
            //    },
            //    Width = 6.4444427490234375,
            //    Height = 44.88206100463867,
            //    OffsetX = 25.51446533203125,
            //    OffsetY = 25.309220790863037,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes201);
            //NodeGroup NetworkShapes202 = new NodeGroup()
            //{
            //    ID = "Smartphone",
            //    Children = new string[] {
            //   "SmartPhone1",
            //   "SmartPhone2",
            //   "SmartPhone3"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes202);
            //Node NetworkShapes203 = new Node()
            //{
            //    ID = "Speaker1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M9,49 C7.8954305,49 7,48.1045695 7,47 L7,3 C7,1.8954305 7.8954305,1 9,1 L41.5,1 C42.6045695,1 43.5,1.8954305 43.5,3 L43.5,47 C43.5,48.1045695 42.6045695,49 41.5,49 L9,49 Z"
            //    },
            //    Width = 36.5,
            //    Height = 48,
            //    OffsetX = 25.25,
            //    OffsetY = 25,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes203);
            //Node NetworkShapes204 = new Node()
            //{
            //    ID = "Speaker2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M9,47 L9,3 L41.5,3 L41.5,47 L9,47 Z M25.25,43.25 C30.5657407,43.25 34.875,38.9407407 34.875,33.625 C34.875,28.3092593 30.5657407,24 25.25,24 C19.9342593,24 15.625,28.3092593 15.625,33.625 C15.625,38.9407407 19.9342593,43.25 25.25,43.25 Z M25.25,20.25 C28.9779221,20.25 32,17.2279221 32,13.5 C32,9.77207794 28.9779221,6.75 25.25,6.75 C21.5220779,6.75 18.5,9.77207794 18.5,13.5 C18.5,17.2279221 21.5220779,20.25 25.25,20.25 Z M25.25,41.25 C21.0388288,41.25 17.625,37.8361712 17.625,33.625 C17.625,29.4138288 21.0388288,26 25.25,26 C29.4611712,26 32.875,29.4138288 32.875,33.625 C32.875,37.8361712 29.4611712,41.25 25.25,41.25 Z M25.25,36.5 C26.8378187,36.5 28.125,35.2128187 28.125,33.625 C28.125,32.0371813 26.8378187,30.75 25.25,30.75 C23.6621813,30.75 22.375,32.0371813 22.375,33.625 C22.375,35.2128187 23.6621813,36.5 25.25,36.5 Z M25.25,18.25 C22.6266474,18.25 20.5,16.1233526 20.5,13.5 C20.5,10.8766474 22.6266474,8.75 25.25,8.75 C27.8733526,8.75 30,10.8766474 30,13.5 C30,16.1233526 27.8733526,18.25 25.25,18.25 Z M25.25,14.9375 C26.0439093,14.9375 26.6875,14.2939093 26.6875,13.5 C26.6875,12.7060907 26.0439093,12.0625 25.25,12.0625 C24.4560907,12.0625 23.8125,12.7060907 23.8125,13.5 C23.8125,14.2939093 24.4560907,14.9375 25.25,14.9375 Z"
            //    },
            //    Width = 32.5,
            //    Height = 44,
            //    OffsetX = 25.25,
            //    OffsetY = 25,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes204);
            //NodeGroup NetworkShapes205 = new NodeGroup()
            //{
            //    ID = "Speaker",
            //    Children = new string[] {
            //   "Speaker1",
            //   "Speaker2"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes205);
            //Node NetworkShapes206 = new Node()
            //{
            //    ID = "Stereo1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M35.176838,41.2860468 C34.8583999,41.5000978 34.4750362,41.625 34.0625,41.625 L15.9375,41.625 C15.5249638,41.625 15.1416001,41.5000978 14.823162,41.2860468 C14.5561964,41.4181161 14.2555162,41.4923401 13.9375,41.4923401 L3,41.4923401 C1.8954305,41.4923401 1,40.5969096 1,39.4923401 L1,10 C1,8.8954305 1.8954305,8 3,8 L13.9375,8 C15.0420695,8 15.9375,8.8954305 15.9375,10 L15.9375,23.8125 L34.0625,23.8125 L34.0625,10 C34.0625,8.8954305 34.9579305,8 36.0625,8 L47,8 C48.1045695,8 49,8.8954305 49,10 L49,39.4923401 C49,40.5969096 48.1045695,41.4923401 47,41.4923401 L36.0625,41.4923401 C35.7444838,41.4923401 35.4438036,41.4181161 35.176838,41.2860468 Z"
            //    },
            //    Width = 48,
            //    Height = 33.625,
            //    OffsetX = 25,
            //    OffsetY = 24.8125,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes206);
            //Node NetworkShapes207 = new Node()
            //{
            //    ID = "Stereo2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M17.8125 34.4375 17.8125 32.4375 23.5625 32.4375 23.5625 34.4375"
            //    },
            //    Width = 5.75,
            //    Height = 2,
            //    OffsetX = 20.6875,
            //    OffsetY = 33.4375,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes207);
            //Node NetworkShapes208 = new Node()
            //{
            //    ID = "Stereo3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M27.875,33.4375 C27.875,34.231 27.231,34.875 26.4375,34.875 C25.6430417,34.875 25,34.231 25,33.4375 C25,32.644 25.6430417,32 26.4375,32 C27.231,32 27.875,32.644 27.875,33.4375"
            //    },
            //    Width = 2.875,
            //    Height = 2.875,
            //    OffsetX = 26.4375,
            //    OffsetY = 33.4375,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes208);
            //Node NetworkShapes209 = new Node()
            //{
            //    ID = "Stereo4",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M32.1875,33.4375 C32.1875,34.231 31.5435,34.875 30.75,34.875 C29.9555417,34.875 29.3125,34.231 29.3125,33.4375 C29.3125,32.644 29.9555417,32 30.75,32 C31.5435,32 32.1875,32.644 32.1875,33.4375"
            //    },
            //    Width = 2.875,
            //    Height = 2.875,
            //    OffsetX = 30.75,
            //    OffsetY = 33.4375,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes209);
            //Node NetworkShapes210 = new Node()
            //{
            //    ID = "Stereo5",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M3,39.4923401 L3,10 L13.9375,10 L13.9375,39.4923401 L3,39.4923401 Z M8.46875,36.3125 C10.4535233,36.3125 12.0625,34.7035233 12.0625,32.71875 C12.0625,30.7339767 10.4535233,29.125 8.46875,29.125 C6.48397668,29.125 4.875,30.7339767 4.875,32.71875 C4.875,34.7035233 6.48397668,36.3125 8.46875,36.3125 Z M8.46875,24.8125 C9.65961399,24.8125 10.625,23.847114 10.625,22.65625 C10.625,21.465386 9.65961399,20.5 8.46875,20.5 C7.27788601,20.5 6.3125,21.465386 6.3125,22.65625 C6.3125,23.847114 7.27788601,24.8125 8.46875,24.8125 Z M15.9375,39.625 L15.9375,25.8125 L34.0625,25.8125 L34.0625,39.625 L15.9375,39.625 Z M27.875,33.4375 C27.875,32.644 27.231,32 26.4375,32 C25.6430417,32 25,32.644 25,33.4375 C25,34.231 25.6430417,34.875 26.4375,34.875 C27.231,34.875 27.875,34.231 27.875,33.4375 Z M32.1875,33.4375 C32.1875,32.644 31.5435,32 30.75,32 C29.9555417,32 29.3125,32.644 29.3125,33.4375 C29.3125,34.231 29.9555417,34.875 30.75,34.875 C31.5435,34.875 32.1875,34.231 32.1875,33.4375 Z M36.0625,39.4923401 L36.0625,10 L47,10 L47,39.4923401 L36.0625,39.4923401 Z M41.53125,36.3125 C43.5160233,36.3125 45.125,34.7035233 45.125,32.71875 C45.125,30.7339767 43.5160233,29.125 41.53125,29.125 C39.5464767,29.125 37.9375,30.7339767 37.9375,32.71875 C37.9375,34.7035233 39.5464767,36.3125 41.53125,36.3125 Z M41.53125,24.8125 C42.722114,24.8125 43.6875,23.847114 43.6875,22.65625 C43.6875,21.465386 42.722114,20.5 41.53125,20.5 C40.340386,20.5 39.375,21.465386 39.375,22.65625 C39.375,23.847114 40.340386,24.8125 41.53125,24.8125 Z"
            //    },
            //    Width = 44,
            //    Height = 29.625,
            //    OffsetX = 25,
            //    OffsetY = 24.8125,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes210);
            //NodeGroup NetworkShapes211 = new NodeGroup()
            //{
            //    ID = "Stereo",
            //    Children = new string[] {
            //   "Stereo1",
            //   "Stereo2",
            //   "Stereo3",
            //   "Stereo4",
            //   "Stereo5"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes211);
            //Node NetworkShapes212 = new Node()
            //{
            //    ID = "Subwoofer1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M35.8571429,45.3571429 L40.4285714,45.3571429 L40.4285714,38.9912458 L35.8571429,38.9912458 L35.8571429,45.3571429 Z M33.8571429,45.3571429 L33.8571429,38.9912458 L29.2857143,38.9912458 C28.1811448,38.9912458 27.2857143,38.0958153 27.2857143,36.9912458 L27.2857143,3 C27.2857143,1.8954305 28.1811448,1 29.2857143,1 L47,1 C48.1045695,1 49,1.8954305 49,3 L49,36.9912458 C49,38.0958153 48.1045695,38.9912458 47,38.9912458 L42.4285714,38.9912458 L42.4285714,45.3571429 L46.3571429,45.3571429 C46.9094276,45.3571429 47.3571429,45.8048581 47.3571429,46.3571429 C47.3571429,46.9094276 46.9094276,47.3571429 46.3571429,47.3571429 L29.9285714,47.3571429 C29.3762867,47.3571429 28.9285714,46.9094276 28.9285714,46.3571429 C28.9285714,45.8048581 29.3762867,45.3571429 29.9285714,45.3571429 L33.8571429,45.3571429 Z M9.57142857,45.3571429 L14.1428571,45.3571429 L14.1428571,38.9912458 L9.57142857,38.9912458 L9.57142857,45.3571429 Z M7.57142857,45.3571429 L7.57142857,38.9912458 L3,38.9912458 C1.8954305,38.9912458 1,38.0958153 1,36.9912458 L1,3 C1,1.8954305 1.8954305,1 3,1 L20.7142857,1 C21.8188552,1 22.7142857,1.8954305 22.7142857,3 L22.7142857,36.9912458 C22.7142857,38.0958153 21.8188552,38.9912458 20.7142857,38.9912458 L16.1428571,38.9912458 L16.1428571,45.3571429 L20.0714286,45.3571429 C20.6237133,45.3571429 21.0714286,45.8048581 21.0714286,46.3571429 C21.0714286,46.9094276 20.6237133,47.3571429 20.0714286,47.3571429 L3.64285714,47.3571429 C3.09057239,47.3571429 2.64285714,46.9094276 2.64285714,46.3571429 C2.64285714,45.8048581 3.09057239,45.3571429 3.64285714,45.3571429 L7.57142857,45.3571429 Z"
            //    },
            //    Width = 48,
            //    Height = 46.35714340209961,
            //    OffsetX = 25,
            //    OffsetY = 24.178571701049805,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes212);
            //Node NetworkShapes213 = new Node()
            //{
            //    ID = "Subwoofer2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M3,36.9912458 L3,3 L20.7142857,3 L20.7142857,36.9912458 L3,36.9912458 Z M11.8571429,30.9285714 C14.2240775,30.9285714 16.1428571,29.0097918 16.1428571,26.6428571 C16.1428571,24.2759225 14.2240775,22.3571429 11.8571429,22.3571429 C9.49020822,22.3571429 7.57142857,24.2759225 7.57142857,26.6428571 C7.57142857,29.0097918 9.49020822,30.9285714 11.8571429,30.9285714 Z M11.8571429,16.7857143 C13.6717927,16.7857143 15.1428571,15.3146499 15.1428571,13.5 C15.1428571,11.6853501 13.6717927,10.2142857 11.8571429,10.2142857 C10.042493,10.2142857 8.57142857,11.6853501 8.57142857,13.5 C8.57142857,15.3146499 10.042493,16.7857143 11.8571429,16.7857143 Z M11.8571429,28.9285714 C10.5947777,28.9285714 9.57142857,27.9052223 9.57142857,26.6428571 C9.57142857,25.380492 10.5947777,24.3571429 11.8571429,24.3571429 C13.119508,24.3571429 14.1428571,25.380492 14.1428571,26.6428571 C14.1428571,27.9052223 13.119508,28.9285714 11.8571429,28.9285714 Z M29.2857143,36.9912458 L29.2857143,3 L47,3 L47,36.9912458 L29.2857143,36.9912458 Z M38.1428571,16.7857143 C39.957507,16.7857143 41.4285714,15.3146499 41.4285714,13.5 C41.4285714,11.6853501 39.957507,10.2142857 38.1428571,10.2142857 C36.3282073,10.2142857 34.8571429,11.6853501 34.8571429,13.5 C34.8571429,15.3146499 36.3282073,16.7857143 38.1428571,16.7857143 Z M38.1428571,30.9285714 C40.5097918,30.9285714 42.4285714,29.0097918 42.4285714,26.6428571 C42.4285714,24.2759225 40.5097918,22.3571429 38.1428571,22.3571429 C35.7759225,22.3571429 33.8571429,24.2759225 33.8571429,26.6428571 C33.8571429,29.0097918 35.7759225,30.9285714 38.1428571,30.9285714 Z M38.1428571,28.9285714 C36.880492,28.9285714 35.8571429,27.9052223 35.8571429,26.6428571 C35.8571429,25.380492 36.880492,24.3571429 38.1428571,24.3571429 C39.4052223,24.3571429 40.4285714,25.380492 40.4285714,26.6428571 C40.4285714,27.9052223 39.4052223,28.9285714 38.1428571,28.9285714 Z"
            //    },
            //    Width = 44,
            //    Height = 33.99124526977539,
            //    OffsetX = 25,
            //    OffsetY = 19.995622634887695,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes213);
            //NodeGroup NetworkShapes214 = new NodeGroup()
            //{
            //    ID = "Subwoofer",
            //    Children = new string[] {
            //   "Subwoofer1",
            //   "Subwoofer2"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes214);
            //Node NetworkShapes215 = new Node()
            //{
            //    ID = "Switch1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M25.0032913,18.4999992 C25.15268,12.1233236 30.3686568,7 36.78125,7 C43.2878547,7 48.5625,12.2746453 48.5625,18.78125 C48.5625,24.0346036 45.1240898,28.4848735 40.375,30.0043291 L40.375,38.0875 C40.375,38.6950132 39.8825132,39.1875 39.275,39.1875 L35.8445187,39.1875 C35.9089158,39.3196495 35.9450478,39.4681052 35.9450478,39.625 C35.9450478,40.1772847 35.4973326,40.625 34.9450478,40.625 L6.3125,40.625 C5.76021525,40.625 5.3125,40.1772847 5.3125,39.625 C5.3125,39.4681052 5.34863207,39.3196495 5.41302911,39.1875 L2.1,39.1875 C1.49248678,39.1875 1,38.6950132 1,38.0875 L1,19.6 C1,18.9924868 1.49248678,18.5 2.1,18.5 L25.0032912,18.5 Z"
            //    },
            //    Width = 47.5625,
            //    Height = 33.625,
            //    OffsetX = 24.78125,
            //    OffsetY = 23.8125,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes215);
            //Node NetworkShapes216 = new Node()
            //{
            //    ID = "Switch2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M33.385704,22.64711 L33.385704,21.4172306 L36.9375,19.6078296 L40.489296,21.4172306 L40.489296,22.6269331 L39.6093485,21.9909285 L38.7306706,23.206628 L41.2281167,25.0117211 L43.950085,23.2258597 L43.1272389,21.9716969 L41.989296,22.718292 L41.989296,20.4979534 L38.5897558,18.7661166 L41.9836807,17.0371403 L41.9836807,14.4202234 L43.0974079,15.1509309 L43.920254,13.8967681 L41.1982858,12.1109066 L38.7008397,13.9159998 L39.5795176,15.1316992 L40.4836807,14.4781921 L40.4836807,16.1178631 L36.9375,17.9244035 L33.3913193,16.1178631 L33.3913193,14.4580152 L34.3233983,15.1316992 L35.2020762,13.9159998 L32.7046301,12.1109066 L29.9826619,13.8967681 L30.805508,15.1509309 L31.8913193,14.4385388 L31.8913193,17.0371403 L35.2852442,18.7661166 L31.885704,20.4979534 L31.885704,22.6999766 L30.7756771,21.9716969 L29.9528309,23.2258597 L32.6747992,25.0117211 L35.1722453,23.206628 L34.2935674,21.9909285 L33.385704,22.64711 Z M25.1244729,20.5 C25.9564581,26.1919304 30.8584535,30.5625 36.78125,30.5625 C37.3217745,30.5625 37.8537971,30.5260988 38.375,30.4556142 L38.375,37.1875 L3,37.1875 L3,20.5 L25.1244729,20.5 Z M8.46875,35.3125 C9.659,35.3125 10.625,34.3465 10.625,33.15625 C10.625,31.966 9.659,31 8.46875,31 C7.2770625,31 6.3125,31.966 6.3125,33.15625 C6.3125,34.3465 7.2770625,35.3125 8.46875,35.3125 Z M15.65625,35.3125 C16.8465,35.3125 17.8125,34.3465 17.8125,33.15625 C17.8125,31.966 16.8465,31 15.65625,31 C14.4645625,31 13.5,31.966 13.5,33.15625 C13.5,34.3465 14.4645625,35.3125 15.65625,35.3125 Z M22.1997528,35.3125 C23.3900028,35.3125 24.3560028,34.3465 24.3560028,33.15625 C24.3560028,31.966 23.3900028,31 22.1997528,31 C21.0080653,31 20.0435028,31.966 20.0435028,33.15625 C20.0435028,34.3465 21.0080653,35.3125 22.1997528,35.3125 Z M29.4105911,35.3125 C30.6008411,35.3125 31.5668411,34.3465 31.5668411,33.15625 C31.5668411,31.966 30.6008411,31 29.4105911,31 C28.2189036,31 27.2543411,31.966 27.2543411,33.15625 C27.2543411,34.3465 28.2189036,35.3125 29.4105911,35.3125 Z M36.78125,28.5625 C31.3792148,28.5625 27,24.1832852 27,18.78125 C27,13.3792148 31.3792148,9 36.78125,9 C42.1832852,9 46.5625,13.3792148 46.5625,18.78125 C46.5625,24.1832852 42.1832852,28.5625 36.78125,28.5625 Z"
            //    },
            //    Width = 43.5625,
            //    Height = 28.1875,
            //    OffsetX = 24.78125,
            //    OffsetY = 23.09375,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes216);
            //Node NetworkShapes217 = new Node()
            //{
            //    ID = "Switch3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M8.46875,35.3125 C7.2770625,35.3125 6.3125,34.3465 6.3125,33.15625 C6.3125,31.966 7.2770625,31 8.46875,31 C9.659,31 10.625,31.966 10.625,33.15625 C10.625,34.3465 9.659,35.3125 8.46875,35.3125 Z M15.65625,35.3125 C14.4645625,35.3125 13.5,34.3465 13.5,33.15625 C13.5,31.966 14.4645625,31 15.65625,31 C16.8465,31 17.8125,31.966 17.8125,33.15625 C17.8125,34.3465 16.8465,35.3125 15.65625,35.3125 Z M22.1997528,35.3125 C21.0080653,35.3125 20.0435028,34.3465 20.0435028,33.15625 C20.0435028,31.966 21.0080653,31 22.1997528,31 C23.3900028,31 24.3560028,31.966 24.3560028,33.15625 C24.3560028,34.3465 23.3900028,35.3125 22.1997528,35.3125 Z M29.4105911,35.3125 C28.2189036,35.3125 27.2543411,34.3465 27.2543411,33.15625 C27.2543411,31.966 28.2189036,31 29.4105911,31 C30.6008411,31 31.5668411,31.966 31.5668411,33.15625 C31.5668411,34.3465 30.6008411,35.3125 29.4105911,35.3125 Z"
            //    },
            //    Width = 25.25434112548828,
            //    Height = 4.3125,
            //    OffsetX = 18.93967056274414,
            //    OffsetY = 33.15625,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes217);
            //Node NetworkShapes218 = new Node()
            //{
            //    ID = "Switch4",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M23.5625,26.6875 L23.5625,28.125 L20.6875,28.125 L20.6875,26.6875 L19.25,26.6875 L19.25,23.8125 L25,23.8125 L25,26.6875 L23.5625,26.6875 Z M9.1875,26.6875 L9.1875,28.125 L6.3125,28.125 L6.3125,26.6875 L4.875,26.6875 L4.875,23.8125 L10.625,23.8125 L10.625,26.6875 L9.1875,26.6875 Z M16.375,26.6875 L16.375,28.125 L13.5,28.125 L13.5,26.6875 L12.0625,26.6875 L12.0625,23.8125 L17.8125,23.8125 L17.8125,26.6875 L16.375,26.6875 Z"
            //    },
            //    Width = 20.125,
            //    Height = 4.3125,
            //    OffsetX = 14.9375,
            //    OffsetY = 25.96875,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes218);
            //NodeGroup NetworkShapes219 = new NodeGroup()
            //{
            //    ID = "Switch",
            //    Children = new string[] {
            //   "Switch1",
            //   "Switch2",
            //   "Switch3",
            //   "Switch4"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes219);
            //Node NetworkShapes220 = new Node()
            //{
            //    ID = "Tablet1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M10.1875,48.8125 C9.0829305,48.8125 8.1875,47.9170695 8.1875,46.8125 L8.1875,2.8125 C8.1875,1.7079305 9.0829305,0.8125 10.1875,0.8125 L39.8125,0.8125 C40.9170695,0.8125 41.8125,1.7079305 41.8125,2.8125 L41.8125,46.8125 C41.8125,47.9170695 40.9170695,48.8125 39.8125,48.8125 L10.1875,48.8125 Z"
            //    },
            //    Width = 33.625,
            //    Height = 48,
            //    OffsetX = 25,
            //    OffsetY = 24.8125,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes220);
            //Node NetworkShapes221 = new Node()
            //{
            //    ID = "Tablet2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M3 10 47 10 47 39.5682281 3 39.5682281"
            //    },
            //    Width = 44,
            //    Height = 29.56822967529297,
            //    OffsetX = 25,
            //    OffsetY = 24.784114837646484,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes221);
            //Node NetworkShapes222 = new Node()
            //{
            //    ID = "Tablet3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M41.15625,27.3125 C42.347114,27.3125 43.3125,26.347114 43.3125,25.15625 C43.3125,23.965386 42.347114,23 41.15625,23 C39.965386,23 39,23.965386 39,25.15625 C39,26.347114 39.965386,27.3125 41.15625,27.3125 Z"
            //    },
            //    Width = 4.3125,
            //    Height = 4.3125,
            //    OffsetX = 41.15625,
            //    OffsetY = 25.15625,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes222);
            //NodeGroup NetworkShapes223 = new NodeGroup()
            //{
            //    ID = "Tablet",
            //    Children = new string[] {
            //   "Tablet1",
            //   "Tablet2",
            //   "Tablet3"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes223);
            //Node NetworkShapes224 = new Node()
            //{
            //    ID = "Tape Backup1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M2.1,38.875 C1.49248678,38.875 1,38.3825132 1,37.775 L1,12.1 C1,11.4924868 1.49248678,11 2.1,11 L47.9,11 C48.5075132,11 49,11.4924868 49,12.1 L49,37.775 C49,38.3825132 48.5075132,38.875 47.9,38.875 L2.1,38.875 Z"
            //    },
            //    Width = 48,
            //    Height = 27.875,
            //    OffsetX = 25,
            //    OffsetY = 24.9375,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes224);
            //Node NetworkShapes225 = new Node()
            //{
            //    ID = "Tape Backup2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M3,36.875 L3,13 L47,13 L47,36.875 L3,36.875 Z M35.0625,32.125 C35.0625,31.3315 34.4185,30.6875 33.625,30.6875 C32.8305417,30.6875 32.1875,31.3315 32.1875,32.125 C32.1875,32.9185 32.8305417,33.5625 33.625,33.5625 C34.4185,33.5625 35.0625,32.9185 35.0625,32.125 Z M39.375,32.125 C39.375,31.3315 38.731,30.6875 37.9375,30.6875 C37.1430417,30.6875 36.5,31.3315 36.5,32.125 C36.5,32.9185 37.1430417,33.5625 37.9375,33.5625 C38.731,33.5625 39.375,32.9185 39.375,32.125 Z M43.6875,32.125 C43.6875,31.3315 43.0435,30.6875 42.25,30.6875 C41.4555417,30.6875 40.8125,31.3315 40.8125,32.125 C40.8125,32.9185 41.4555417,33.5625 42.25,33.5625 C43.0435,33.5625 43.6875,32.9185 43.6875,32.125 Z M7.85,28.8125 L42.15,28.8125 C42.7575132,28.8125 43.25,28.3200132 43.25,27.7125 L43.25,17.85 C43.25,17.2424868 42.7575132,16.75 42.15,16.75 L7.85,16.75 C7.24248678,16.75 6.75,17.2424868 6.75,17.85 L6.75,27.7125 C6.75,28.3200132 7.24248678,28.8125 7.85,28.8125 Z M8.75,26.8125 L8.75,18.75 L41.25,18.75 L41.25,26.8125 L8.75,26.8125 Z"
            //    },
            //    Width = 44,
            //    Height = 23.875,
            //    OffsetX = 25,
            //    OffsetY = 24.9375,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes225);
            //Node NetworkShapes226 = new Node()
            //{
            //    ID = "Tape Backup3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M35.0625,32.125 C35.0625,32.9185 34.4185,33.5625 33.625,33.5625 C32.8305417,33.5625 32.1875,32.9185 32.1875,32.125 C32.1875,31.3315 32.8305417,30.6875 33.625,30.6875 C34.4185,30.6875 35.0625,31.3315 35.0625,32.125"
            //    },
            //    Width = 2.875,
            //    Height = 2.875,
            //    OffsetX = 33.625,
            //    OffsetY = 32.125,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes226);
            //Node NetworkShapes227 = new Node()
            //{
            //    ID = "Tape Backup4",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M39.375,32.125 C39.375,32.9185 38.731,33.5625 37.9375,33.5625 C37.1430417,33.5625 36.5,32.9185 36.5,32.125 C36.5,31.3315 37.1430417,30.6875 37.9375,30.6875 C38.731,30.6875 39.375,31.3315 39.375,32.125"
            //    },
            //    Width = 2.875,
            //    Height = 2.875,
            //    OffsetX = 37.9375,
            //    OffsetY = 32.125,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes227);
            //NodeGroup NetworkShapes228 = new NodeGroup()
            //{
            //    ID = "Tape Backup",
            //    Children = new string[] {
            //   "Tape Backup1",
            //   "Tape Backup2",
            //   "Tape Backup3",
            //   "Tape Backup4"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes228);
            //Node NetworkShapes229 = new Node()
            //{
            //    ID = "UPS1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M31.332641,45.8275862 L20.0945926,45.8275862 L20.0945926,46.9472097 C20.0945926,47.4994944 19.6468773,47.9472097 19.0945926,47.9472097 L14.332641,47.9472097 C13.7803563,47.9472097 13.332641,47.4994944 13.332641,46.9472097 L13.332641,45.8275862 L8.1,45.8275862 C7.49248678,45.8275862 7,45.3350994 7,44.7275862 L7,2.1 C7,1.49248678 7.49248678,1 8.1,1 L42.7965517,1 C43.4040649,1 43.8965517,1.49248678 43.8965517,2.1 L43.8965517,44.7275862 C43.8965517,45.3350994 43.4040649,45.8275862 42.7965517,45.8275862 L38.0945926,45.8275862 L38.0945926,46.9472097 C38.0945926,47.4994944 37.6468773,47.9472097 37.0945926,47.9472097 L32.332641,47.9472097 C31.7803563,47.9472097 31.332641,47.4994944 31.332641,46.9472097 L31.332641,45.8275862 Z"
            //    },
            //    Width = 36.89655303955078,
            //    Height = 46.947208404541016,
            //    OffsetX = 25.44827651977539,
            //    OffsetY = 24.473604202270508,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes229);
            //Node NetworkShapes230 = new Node()
            //{
            //    ID = "UPS2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M14.3448276,3 L14.3448276,22.3875606 C14.3448276,28.9578447 19.6710952,34.2841123 26.2413793,34.2841123 C32.8116634,34.2841123 38.137931,28.9578447 38.137931,22.3875606 L38.137931,3 L41.8965517,3 L41.8965517,43.8275862 L9,43.8275862 L9,3 L14.3448276,3 Z M19.1034483,38.4827586 C19.1034483,37.6071724 18.3928276,36.8965517 17.5172414,36.8965517 C16.6405977,36.8965517 15.9310345,37.6071724 15.9310345,38.4827586 C15.9310345,39.3583448 16.6405977,40.0689655 17.5172414,40.0689655 C18.3928276,40.0689655 19.1034483,39.3583448 19.1034483,38.4827586 Z M16.3448276,4 L36.137931,4 L36.137931,22.3875606 C36.137931,27.8532752 31.7070939,32.2841123 26.2413793,32.2841123 C20.7756647,32.2841123 16.3448276,27.8532752 16.3448276,22.3875606 L16.3448276,4 Z M26.2413793,26.7931034 C28.9837588,26.7931034 31.2068966,24.5699657 31.2068966,21.8275862 C31.2068966,19.0852068 28.9837588,16.862069 26.2413793,16.862069 C23.4989999,16.862069 21.2758621,19.0852068 21.2758621,21.8275862 C21.2758621,24.5699657 23.4989999,26.7931034 26.2413793,26.7931034 Z M20.6896552,11.5172414 L20.6896552,13.1034483 L31.7931034,13.1034483 L31.7931034,11.5172414 L20.6896552,11.5172414 Z M20.6896552,8.34482759 L20.6896552,9.93103448 L31.7931034,9.93103448 L31.7931034,8.34482759 L20.6896552,8.34482759 Z"
            //    },
            //    Width = 32.89655303955078,
            //    Height = 40.82758712768555,
            //    OffsetX = 25.44827651977539,
            //    OffsetY = 23.413793563842773,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes230);
            //Node NetworkShapes231 = new Node()
            //{
            //    ID = "UPS3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M19.1034483,38.4827586 C19.1034483,39.3583448 18.3928276,40.0689655 17.5172414,40.0689655 C16.6405977,40.0689655 15.9310345,39.3583448 15.9310345,38.4827586 C15.9310345,37.6071724 16.6405977,36.8965517 17.5172414,36.8965517 C18.3928276,36.8965517 19.1034483,37.6071724 19.1034483,38.4827586"
            //    },
            //    Width = 3.172414779663086,
            //    Height = 3.172412872314453,
            //    OffsetX = 17.51724147796631,
            //    OffsetY = 38.48275947570801,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes231);
            //Node NetworkShapes232 = new Node()
            //{
            //    ID = "UPS4",
            //    Shape = new BasicShape()
            //    {
            //        Type = Shapes.Basic,
            //        Shape = BasicShapeType.Rectangle
            //    },
            //    Width = 14.275861740112305,
            //    Height = 3.1724138259887695,
            //    OffsetX = 27.82758617401123,
            //    OffsetY = 38.482759952545166,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes232);
            //Node NetworkShapes233 = new Node()
            //{
            //    ID = "UPS5",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M26.2413793,24.7931034 C27.8791893,24.7931034 29.2068966,23.4653962 29.2068966,21.8275862 C29.2068966,20.1897763 27.8791893,18.862069 26.2413793,18.862069 C24.6035694,18.862069 23.2758621,20.1897763 23.2758621,21.8275862 C23.2758621,23.4653962 24.6035694,24.7931034 26.2413793,24.7931034 Z"
            //    },
            //    Width = 5.931034088134766,
            //    Height = 5.931035995483398,
            //    OffsetX = 26.241378784179688,
            //    OffsetY = 21.82758617401123,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes233);
            //NodeGroup NetworkShapes234 = new NodeGroup()
            //{
            //    ID = "UPS",
            //    Children = new string[] {
            //   "UPS1",
            //   "UPS2",
            //   "UPS3",
            //   "UPS4",
            //   "UPS5"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes234);
            //Node NetworkShapes235 = new Node()
            //{
            //    ID = "USB1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M16.7878788,12.1515152 L16.7878788,2.1 C16.7878788,1.49248678 17.2803656,1 17.8878788,1 L33.0212121,1 C33.6287253,1 34.1212121,1.49248678 34.1212121,2.1 L34.1212121,12.1515152 L35.8090909,12.1515152 C36.4166041,12.1515152 36.9090909,12.6440019 36.9090909,13.2515152 L36.9090909,37.5454545 C36.9090909,43.8716253 31.7807162,49 25.4545455,49 C19.1283747,49 14,43.8716253 14,37.5454545 L14,13.2515152 C14,12.6440019 14.4924868,12.1515152 15.1,12.1515152 L16.7878788,12.1515152 Z M32.1212121,12.1515152 L32.1212121,3 L18.7878788,3 L18.7878788,12.1515152 L32.1212121,12.1515152 Z M21.969697,6.18181818 L24.7575758,6.18181818 L24.7575758,8.96969697 L21.969697,8.96969697 L21.969697,6.18181818 Z M26.1515152,6.18181818 L28.9393939,6.18181818 L28.9393939,8.96969697 L26.1515152,8.96969697 L26.1515152,6.18181818 Z"
            //    },
            //    Width = 22.90909194946289,
            //    Height = 48,
            //    OffsetX = 25.454545974731445,
            //    OffsetY = 25,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes235);
            //Node NetworkShapes236 = new Node()
            //{
            //    ID = "USB2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M16,14.1515152 L16,37.5454545 C16,42.7670558 20.2329442,47 25.4545455,47 C30.6761467,47 34.9090909,42.7670558 34.9090909,37.5454545 L34.9090909,14.1515152 L16,14.1515152 Z"
            //    },
            //    Width = 18.90909194946289,
            //    Height = 32.84848403930664,
            //    OffsetX = 25.454545974731445,
            //    OffsetY = 30.575757026672363,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes236);
            //NodeGroup NetworkShapes237 = new NodeGroup()
            //{
            //    ID = "USB",
            //    Children = new string[] {
            //   "USB1",
            //   "USB2"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes237);
            //Node NetworkShapes238 = new Node()
            //{
            //    ID = "User Group1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M22.6416774,14.9586093 C23.4205865,14.6339839 24.2753169,14.4547368 25.172,14.4547368 C26.0686831,14.4547368 26.9234135,14.6339839 27.7023226,14.9586093 C28.4244834,12.1082627 31.00626,10 34.0814737,10 C37.7163816,10 40.6618947,12.9455131 40.6618947,16.5804211 C40.6618947,18.4313369 39.8901842,20.1312502 38.6258294,21.3402726 C40.6135116,21.7309118 42.4448305,22.6722831 43.9261084,24.061334 C46.0917876,26.0929233 47.344,28.9224292 47.344,31.9514905 L47.344,32.12968 C47.344,34.5584763 45.3729522,36.5250526 42.9397179,36.5250526 L38.4345263,36.5250526 L38.4345263,36.5844168 C38.4345263,39.0132131 36.4634785,40.9797895 34.0302442,40.9797895 L16.3159832,40.9797895 C13.8825289,40.9797895 11.9094737,39.0129951 11.9094737,36.5844168 L11.9094737,36.5250526 L7.40650947,36.5250526 C4.97305517,36.5250526 3,34.5582583 3,32.12968 L3,31.9514905 C3,26.6962328 6.74855703,22.3171317 11.7180011,21.3402689 C10.4535094,20.1317144 9.68210526,18.4323345 9.68210526,16.5804211 C9.68210526,12.9455131 12.6276184,10 16.2625263,10 C19.33774,10 21.9195166,12.1082627 22.6416774,14.9586093 Z"
            //    },
            //    Width = 44.34400177001953,
            //    Height = 30.97978973388672,
            //    OffsetX = 25.172000885009766,
            //    OffsetY = 25.48989486694336,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes238);
            //Node NetworkShapes239 = new Node()
            //{
            //    ID = "User Group2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M31.7297291,20.4846065 C31.5863266,18.7524592 30.772364,17.2109009 29.5480006,16.1200908 C29.7786612,13.8193213 31.7197766,12.024 34.0814737,12.024 C36.5985573,12.024 38.6378947,14.0633374 38.6378947,16.5804211 C38.6378947,18.628722 37.2716308,20.4114266 35.3321681,20.9639695 C34.9312342,21.0779964 34.5096601,21.1368421 34.0814737,21.1368421 C33.6539291,21.1368421 33.2345853,21.0781798 32.8325644,20.9638436 C32.4391101,20.8518575 32.0693089,20.6894532 31.7297291,20.4846065 Z M31.3991968,23.1639631 C31.4778194,23.1618868 31.5566992,23.1608421 31.6358232,23.1608421 L36.5293516,23.1608421 C38.7942752,23.1608421 40.9229431,24.0198425 42.5414885,25.5376144 C44.303352,27.1903906 45.32,29.4876139 45.32,31.9514905 L45.32,32.12968 C45.32,33.4396216 44.2561556,34.5010526 42.9397179,34.5010526 L38.2669121,34.5010526 C37.8587982,32.2064486 36.7203937,30.1143401 35.0166347,28.5160709 C33.5353568,27.1270199 31.7040379,26.1856486 29.7163558,25.7950095 C30.4744806,25.0700627 31.0554816,24.1686225 31.3991968,23.1639631 Z M18.6142348,20.4850426 C18.2751186,20.6897803 17.9059195,20.8520916 17.5132207,20.9639695 C17.1122869,21.0779964 16.6907127,21.1368421 16.2625263,21.1368421 C15.8349817,21.1368421 15.4156379,21.0781798 15.0136171,20.9638436 C13.071797,20.4111575 11.7061053,18.630418 11.7061053,16.5804211 C11.7061053,14.0633374 13.7454427,12.024 16.2625263,12.024 C18.6242234,12.024 20.5653388,13.8193213 20.7959994,16.1200908 C19.5715332,17.2109924 18.7575368,18.7527179 18.6142348,20.4850426 Z M18.9444913,23.1639056 C19.2881043,24.1688315 19.8691113,25.07019 20.6274747,25.7950058 C16.2727344,26.6510338 12.8555224,30.1196664 12.0767582,34.5010526 L7.40650947,34.5010526 C6.08944203,34.5010526 5.024,33.4389914 5.024,32.12968 L5.024,31.9514905 C5.024,27.096166 8.96055928,23.1608421 13.8168758,23.1608421 L18.7104042,23.1608421 C18.7886008,23.1608421 18.8666349,23.161866 18.9444913,23.1639056 Z M27.6198779,27.6155789 C29.8848015,27.6155789 32.0134695,28.4745794 33.6320148,29.9923513 C35.3938783,31.6451275 36.4105263,33.9423507 36.4105263,36.4062274 L36.4105263,36.5844168 C36.4105263,37.8943585 35.3466819,38.9557895 34.0302442,38.9557895 L16.3159832,38.9557895 C14.9989157,38.9557895 13.9334737,37.8937283 13.9334737,36.5844168 L13.9334737,36.4062274 C13.9334737,31.5509028 17.870033,27.6155789 22.7263495,27.6155789 L27.6198779,27.6155789 Z M29.7284211,21.0351579 C29.7284211,23.0834589 28.3621571,24.8661634 26.4226944,25.4187063 C26.0217605,25.5327333 25.6001864,25.5915789 25.172,25.5915789 C24.7444554,25.5915789 24.3251116,25.5329167 23.9230907,25.4185804 C21.9812707,24.8658943 20.6155789,23.0851549 20.6155789,21.0351579 C20.6155789,18.5180743 22.6549164,16.4787368 25.172,16.4787368 C27.6890836,16.4787368 29.7284211,18.5180743 29.7284211,21.0351579 Z"
            //    },
            //    Width = 40.295997619628906,
            //    Height = 26.931787490844727,
            //    OffsetX = 25.171998977661133,
            //    OffsetY = 25.489893913269043,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes239);
            //NodeGroup NetworkShapes240 = new NodeGroup()
            //{
            //    ID = "User Group",
            //    Children = new string[] {
            //   "User Group1",
            //   "User Group2"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes240);
            //Node NetworkShapes241 = new Node()
            //{
            //    ID = "User1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M35.5206786,12.7257514 C35.5206786,17.2284014 32.5568727,21.1472462 28.3355228,22.365323 C27.4580283,22.6181373 26.5449409,22.7474212 25.6144427,22.7474212 C24.6876354,22.7474212 23.7780922,22.6182178 22.9001435,22.3652726 C18.6751443,21.1473015 15.7116847,17.2315879 15.7116847,12.7257514 C15.7116847,7.19404431 20.1419452,2.70408163 25.6144427,2.70408163 C31.0898071,2.70408163 35.5206786,7.19342817 35.5206786,12.7257514 Z M28.9249598,23.872549 C33.1867272,23.872549 37.1945151,25.5123908 40.2432117,28.4070931 C43.5557449,31.5547482 45.470324,35.934673 45.470324,40.6223904 L45.470324,40.9055328 C45.470324,44.5192074 42.5630561,47.4551687 38.9758141,47.4551687 L11.1985915,47.4551687 C7.61134953,47.4551687 4.70408163,44.5192074 4.70408163,40.9055328 L4.70408163,40.6223904 C4.70408163,31.3755157 12.1102841,23.872549 21.2494458,23.872549 L28.9249598,23.872549 Z"
            //    },
            //    Width = 40.76624298095703,
            //    Height = 44.7510871887207,
            //    OffsetX = 25.08720302581787,
            //    OffsetY = 25.079625129699707,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes241);
            //Node NetworkShapes242 = new Node()
            //{
            //    ID = "User2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M28.9249598,26.2194878 C32.5779124,26.2194878 36.0095073,27.6235723 38.6268867,30.1087438 C41.4768234,32.8168278 43.1233853,36.5836176 43.1233853,40.6223904 L43.1233853,40.9055328 C43.1233853,43.2281605 41.2616899,45.10823 38.9758141,45.10823 L11.1985915,45.10823 C8.91271571,45.10823 7.05102041,43.2281605 7.05102041,40.9055328 L7.05102041,40.6223904 C7.05102041,32.6649238 13.4133309,26.2194878 21.2494458,26.2194878 L28.9249598,26.2194878 Z M33.1737398,12.7257514 C33.1737398,16.1803409 30.9039746,19.1815015 27.6853167,20.1102501 C27.0191983,20.302165 26.3248161,20.4004824 25.6144427,20.4004824 C24.9081221,20.4004824 24.2172639,20.3023439 23.5500641,20.1101174 C20.3275718,19.1811463 18.0586234,16.1831125 18.0586234,12.7257514 C18.0586234,8.48324257 21.445208,5.05102041 25.6144427,5.05102041 C29.7866909,5.05102041 33.1737398,8.48276883 33.1737398,12.7257514 Z"
            //    },
            //    Width = 36.072364807128906,
            //    Height = 40.05720901489258,
            //    OffsetX = 25.08720302581787,
            //    OffsetY = 25.079625129699707,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes242);
            //NodeGroup NetworkShapes243 = new NodeGroup()
            //{
            //    ID = "User",
            //    Children = new string[] {
            //   "User1",
            //   "User2"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes243);
            //Node NetworkShapes244 = new Node()
            //{
            //    ID = "Video Projector1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M47.6060606,25.281559 L47.6060606,34.2030303 C47.6060606,34.8105435 47.1135738,35.3030303 46.5060606,35.3030303 L42.030303,35.3030303 L42.030303,37.0809091 C41.8042068,37.8648129 41.8042068,37.8648129 41.020303,38.0909091 L34.0706061,38.0909091 C33.2867023,37.8648129 33.2867023,37.8648129 33.0606061,37.0809091 L33.0606061,35.3030303 L15.5454545,35.3030303 L15.5454545,37.0809091 C15.3193583,37.8648129 15.3193583,37.8648129 14.5354545,38.0909091 L7.58575758,38.0909091 C6.80185378,37.8648129 6.80185378,37.8648129 6.57575758,37.0809091 L6.57575758,35.3030303 L2.1,35.3030303 C1.49248678,35.3030303 1,34.8105435 1,34.2030303 L1,17.6757576 C1,17.0682444 1.49248678,16.5757576 2.1,16.5757576 L31.0705255,16.5757576 C32.5250467,13.2913752 35.8131155,11 39.6363636,11 C44.8077572,11 49,15.1922428 49,20.3636364 C49,22.1675448 48.4898943,23.8523116 47.6060606,25.281559 Z"
            //    },
            //    Width = 48,
            //    Height = 27.09090805053711,
            //    OffsetX = 25,
            //    OffsetY = 24.545454025268555,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes244);
            //Node NetworkShapes245 = new Node()
            //{
            //    ID = "Video Projector2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M30.4442719,18.5703278 C30.3316955,19.1507511 30.2727273,19.7503073 30.2727273,20.3636364 C30.2727273,25.5350299 34.4649701,29.7272727 39.6363636,29.7272727 C41.905169,29.7272727 43.9855101,28.9203616 45.6060606,27.5778657 L45.6060606,33.3218991 L3,33.3218991 L3,18.5703278 L30.4442719,18.5703278 Z M22.9090909,23.1515152 C22.9090909,23.9209697 23.5335758,24.5454545 24.3030303,24.5454545 C25.0734141,24.5454545 25.6969697,23.9209697 25.6969697,23.1515152 C25.6969697,22.3820606 25.0734141,21.7575758 24.3030303,21.7575758 C23.5335758,21.7575758 22.9090909,22.3820606 22.9090909,23.1515152 Z M22.9090909,28.7272727 C22.9090909,29.4967273 23.5335758,30.1212121 24.3030303,30.1212121 C25.0734141,30.1212121 25.6969697,29.4967273 25.6969697,28.7272727 C25.6969697,27.9578182 25.0734141,27.3333333 24.3030303,27.3333333 C23.5335758,27.3333333 22.9090909,27.9578182 22.9090909,28.7272727 Z"
            //    },
            //    Width = 42.60606002807617,
            //    Height = 14.751571655273438,
            //    OffsetX = 24.303030014038086,
            //    OffsetY = 25.94611358642578,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes245);
            //Node NetworkShapes246 = new Node()
            //{
            //    ID = "Video Projector3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M6.18181818 24.1515152 6.18181818 22.1515152 21.5151515 22.1515152 21.5151515 24.1515152"
            //    },
            //    Width = 15.333333969116211,
            //    Height = 2,
            //    OffsetX = 13.848484992980957,
            //    OffsetY = 23.15151596069336,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes246);
            //Node NetworkShapes247 = new Node()
            //{
            //    ID = "Video Projector4",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M6.18181818 29.7272727 6.18181818 27.7272727 21.5151515 27.7272727 21.5151515 29.7272727"
            //    },
            //    Width = 15.333333969116211,
            //    Height = 2,
            //    OffsetX = 13.848484992980957,
            //    OffsetY = 28.727272033691406,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes247);
            //Node NetworkShapes248 = new Node()
            //{
            //    ID = "Video Projector5",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M39.6363636,27.7272727 C35.5695396,27.7272727 32.2727273,24.4304604 32.2727273,20.3636364 C32.2727273,16.2968123 35.5695396,13 39.6363636,13 C43.7031877,13 47,16.2968123 47,20.3636364 C47,24.4304604 43.7031877,27.7272727 39.6363636,27.7272727 Z M39.6363636,23.1515152 C41.1760666,23.1515152 42.4242424,21.9033393 42.4242424,20.3636364 C42.4242424,18.8239334 41.1760666,17.5757576 39.6363636,17.5757576 C38.0966607,17.5757576 36.8484848,18.8239334 36.8484848,20.3636364 C36.8484848,21.9033393 38.0966607,23.1515152 39.6363636,23.1515152 Z"
            //    },
            //    Width = 14.727272033691406,
            //    Height = 14.727272033691406,
            //    OffsetX = 39.6363639831543,
            //    OffsetY = 20.363636016845703,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes248);
            //NodeGroup NetworkShapes249 = new NodeGroup()
            //{
            //    ID = "Video Projector",
            //    Children = new string[] {
            //   "Video Projector1",
            //   "Video Projector2",
            //   "Video Projector3",
            //   "Video Projector4",
            //   "Video Projector5"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes249);
            //Node NetworkShapes250 = new Node()
            //{
            //    ID = "Videoscreen1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M5.3125,8.75 L2.1,8.75 C1.49248678,8.75 1,8.25751322 1,7.65 L1,2.1 C1,1.49248678 1.49248678,1 2.1,1 L47.9,1 C48.5075132,1 49,1.49248678 49,2.1 L49,7.65 C49,8.25751322 48.5075132,8.75 47.9,8.75 L44.6875,8.75 L44.6875,33.525 C44.6875,34.1325132 44.1950132,34.625 43.5875,34.625 L26,34.625 L26,42.428685 C27.094824,42.8348849 27.875,43.8888325 27.875,45.125 C27.875,46.7128187 26.5878187,48 25,48 C23.4121813,48 22.125,46.7128187 22.125,45.125 C22.125,43.8888325 22.905176,42.8348849 24,42.428685 L24,34.625 L6.4125,34.625 C5.80498678,34.625 5.3125,34.1325132 5.3125,33.525 L5.3125,8.75 Z"
            //    },
            //    Width = 48,
            //    Height = 47,
            //    OffsetX = 25,
            //    OffsetY = 24.5,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes250);
            //Node NetworkShapes251 = new Node()
            //{
            //    ID = "Videoscreen2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M7.3125,32.625 L7.3125,8.75 L42.6875,8.75 L42.6875,32.625 L7.3125,32.625 Z M3,6.75 L3,3 L47,3 L47,6.75 L3,6.75 Z"
            //    },
            //    Width = 44,
            //    Height = 29.625,
            //    OffsetX = 25,
            //    OffsetY = 17.8125,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes251);
            //NodeGroup NetworkShapes252 = new NodeGroup()
            //{
            //    ID = "Video Screen",
            //    Children = new string[] {
            //   "Videoscreen1",
            //   "Videoscreen2"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes252);
            //Node NetworkShapes253 = new Node()
            //{
            //    ID = "Virtual Server Copy1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M40.766335,19.0865917 C46.0186486,22.1140061 48.8292292,28.1610983 47.7837429,34.1330201 C47.6999995,34.6100755 47.2650772,34.9359535 46.7884401,34.8775108 C46.3114893,34.8191727 45.9603104,34.4009782 45.9856112,33.9239229 C46.1611483,30.4530132 44.4047315,27.2160833 41.3936267,25.4762897 C40.4233109,24.9245867 39.3696699,24.5480025 38.2738958,24.3724654 C38.3825218,25.0835006 38.4495375,25.8112635 38.4495375,26.5553361 C38.4495375,32.3516162 34.7695306,37.3116118 29.6171655,39.2102148 C30.3282006,40.0963689 31.1980452,40.8494326 32.1851932,41.417968 C33.5900131,42.2209014 35.1708928,42.6476689 36.7767596,42.6476689 C38.5581635,42.6476689 40.2978526,42.1375762 41.7950934,41.1671559 C42.1965601,40.8997205 42.7319536,40.9997736 43.0161167,41.3845125 C43.3003844,41.7691469 43.2420463,42.3131133 42.8740352,42.6222636 C40.27297,44.8137072 36.969129,46.0181074 33.5565575,46.0181074 C31.0392358,46.0181074 28.5467967,45.3491007 26.355353,44.0859443 C25.8955482,43.8270819 25.4437936,43.5256682 25.0088713,43.207945 C24.5739491,43.5256682 24.122299,43.8185089 23.6619715,44.0859443 C21.470946,45.3491007 18.9785069,46.0181074 16.460767,46.0181074 C13.0483,46.0181074 9.74477266,44.8137072 7.14328932,42.6222636 C6.77538273,42.3131133 6.71694005,41.7691469 7.00120775,41.3845125 C7.28589364,40.9997736 7.82086894,40.9078753 8.22233564,41.1671559 C9.7194719,42.1375762 11.4510062,42.6476689 13.2406695,42.6476689 C14.8464317,42.6476689 16.4358844,42.2209014 17.832654,41.417968 C18.8111245,40.8494326 19.6723961,40.1049419 20.3752765,39.2350974 C15.1894557,37.3532222 11.4678385,32.3764987 11.4678385,26.5471813 C11.4678385,25.8112635 11.5261766,25.0835006 11.6433756,24.3810384 C10.5811616,24.5648349 9.56055799,24.9245867 8.6236978,25.468135 C5.64615307,27.1912008 3.89004988,30.3945705 4.03223601,33.8320246 C4.0403908,33.8737395 4.0403908,33.9157681 4.0403908,33.966056 C4.0403908,34.4674712 3.63892409,34.8689379 3.13698616,34.8775108 C2.68575432,34.8775108 2.3005972,34.5679424 2.22542674,34.1248653 C1.15505795,28.1529435 3.96522034,22.1140061 9.19265139,19.0947465 C9.66102922,18.8187381 10.1462394,18.5760808 10.6481773,18.3588287 C10.5811616,17.7818249 10.5477061,17.2047165 10.5477061,16.6358674 C10.5477061,10.5720474 14.3783675,5.11879135 20.0738628,3.06127449 C20.5255128,2.90236058 21.0274507,3.11145783 21.2198202,3.55463943 C21.4121897,3.99813468 21.2283932,4.5082274 20.8016257,4.72589763 C17.7071956,6.30635914 15.7832919,9.45139076 15.7832919,12.9223004 C15.7832919,14.0180745 15.9842344,15.1051711 16.3689733,16.1339295 C18.7024985,14.210444 21.688198,13.0563318 24.9332827,13.0563318 C28.2205004,13.0563318 31.2397601,14.2353266 33.5818583,16.2009452 C33.983325,15.155459 34.1924222,14.0429571 34.1924222,12.9137274 C34.1924222,9.44281777 32.2685185,6.29820434 29.1740884,4.71732465 C28.7473209,4.50007261 28.5635245,3.98956169 28.7558939,3.54648464 C28.9482634,3.10288484 29.4502013,2.8937876 29.9014332,3.0531197 C35.597242,5.11063656 39.4280081,10.5720474 39.4280081,16.6277127 C39.4280081,17.2047165 39.3863977,17.7818249 39.319382,18.3588287 C39.82132,18.5760808 40.3064256,18.8187381 40.766335,19.0865917 Z M30.9554924,19.9311354 C29.3746127,18.4841825 27.2587577,17.5976102 24.9419602,17.6061832 C22.6500453,17.6061832 20.5590729,18.4674547 18.9785069,19.8895251 C20.2163625,20.9598939 21.7217581,21.6876568 23.369549,21.9804975 C24.4485953,22.172867 25.5271189,22.172867 26.6060606,21.9804975 C28.2286552,21.6958116 29.7257915,20.9766216 30.9554924,19.9311354 Z M16.0009621,26.5471813 C16.0009621,30.5534844 18.6354828,33.9406507 22.2738794,35.0780351 C22.5581471,33.4890006 22.4327933,31.8329505 21.8556849,30.2687985 C21.6714703,29.7672788 21.4456452,29.290328 21.1863647,28.8386779 C20.9102517,28.353886 20.5758007,27.8854036 20.1996348,27.4419084 C19.120693,26.1873249 17.7239234,25.2590377 16.1847586,24.7322172 C16.0679778,25.3174804 16.0009621,25.9280443 16.0009621,26.5471813 Z M27.7104077,35.0449977 C31.2899434,33.8823125 33.8828537,30.5200289 33.8828537,26.5471813 C33.8828537,25.9366173 33.8244111,25.3427812 33.7072121,24.7657773 C32.2015028,25.2925978 30.8468663,26.2040527 29.7846523,27.4419084 C29.4080682,27.8854036 29.081772,28.353886 28.7975043,28.8386779 C28.5382237,29.2821732 28.3123987,29.7672788 28.1286022,30.2687985 C27.5597531,31.8162227 27.4257218,33.4555451 27.7104077,35.0449977 Z"
            //    },
            //    Width = 46,
            //    Height = 43.01810836791992,
            //    OffsetX = 25,
            //    OffsetY = 24.50905418395996,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes253);
            //NodeGroup NetworkShapes254 = new NodeGroup()
            //{
            //    ID = "Virtual Server Copy",
            //    Children = new string[] {
            //   "Virtual Server Copy1"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes254);
            //Node NetworkShapes255 = new Node()
            //{
            //    ID = "Virtual Server1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M25.7741935,46.516129 L44.0645161,46.516129 C44.6168009,46.516129 45.0645161,46.9638443 45.0645161,47.516129 C45.0645161,48.0684138 44.6168009,48.516129 44.0645161,48.516129 L5.48387097,48.516129 C4.93158622,48.516129 4.48387097,48.0684138 4.48387097,47.516129 C4.48387097,46.9638443 4.93158622,46.516129 5.48387097,46.516129 L23.7741935,46.516129 L23.7741935,40.0967742 L25.7741935,40.0967742 L25.7741935,46.516129 Z M6,39.6129032 C4.34314575,39.6129032 3,38.2697575 3,36.6129032 L3,36.5897912 L5,36.5897912 L5,35.5897912 L3,35.5897912 L3,31.5897912 L5,31.5897912 L5,28.7419355 C5,28.6100243 5.02554105,28.4840786 5.0719476,28.3687739 C5.02526822,28.4849639 5,28.6111499 5,28.7419355 L5,30.5897912 L3,30.5897912 L3,28.7419355 C3,27.9855477 3.28268327,27.2795839 3.76374069,26.7417647 C3.28879163,26.2110287 3,25.5102075 3,24.7419355 L3,24.7188234 L5,24.7188234 L5,23.7188234 L3,23.7188234 L3,19.7188234 L5,19.7188234 L5,18.7188234 L3,18.7188234 L3,16.8709677 C3,16.1145799 3.28268327,15.4086161 3.76374069,14.870797 C3.28879163,14.3400609 3,13.6392398 3,12.8709677 L3,12.8478557 L5,12.8478557 L5,11.8478557 L3,11.8478557 L3,7.84785569 L5,7.84785569 L5,5 C5,4.86808885 5.02554105,4.74214313 5.0719476,4.62683841 C5.16258575,4.40123035 5.33394965,4.2133102 5.55780255,4.10258518 L4.67108076,2.3098988 C3.65648507,2.81175128 3,3.84732495 3,5 L3,6.84785569 L5,6.84785569 L5,5 C5,4.86921443 5.02526822,4.74302837 5.0719476,4.62683841 C5.21983567,4.25938607 5.5796264,4 6,4 L6.09067685,4 L6.09067685,2 L10.0906769,2 L10.0906769,4 L11.0906769,4 L11.0906769,2 L15.0906769,2 L15.0906769,4 L16.0906769,4 L16.0906769,2 L20.0906769,2 L20.0906769,4 L21.0906769,4 L21.0906769,2 L25.0906769,2 L25.0906769,4 L26.0906769,4 L26.0906769,2 L30.0906769,2 L30.0906769,4 L31.0906769,4 L31.0906769,2 L35.0906769,2 L35.0906769,4 L36.0906769,4 L36.0906769,2 L40.0906769,2 L40.0906769,4 L41.0906769,4 L41.0906769,2 L43.5483871,2 C44.3605194,2 45.123497,2.32557877 45.6828601,2.89191404 L44.2599147,4.29734146 C44.411356,4.45068247 44.5135913,4.65273252 44.5410048,4.87787583 C44.5355387,4.83166496 44.5268105,4.78629301 44.5150104,4.74187471 L46.447964,4.2283669 C46.5144279,4.47855128 46.5483871,4.73749479 46.5483871,5 L46.5483871,8.4808223 L44.5483871,8.4808223 L44.5483871,9.4808223 L46.5483871,9.4808223 L46.5483871,12.8709677 C46.5483871,13.1245048 46.5167088,13.3747467 46.4546398,13.6170158 L44.5172135,13.1206497 C44.5281801,13.0778444 44.5363041,13.034168 44.5415046,12.9897421 C44.5125843,13.233343 44.396179,13.4501312 44.2245501,13.6077276 L44.6631978,14.0851827 C45.0438749,14.2375423 45.3910707,14.4674554 45.6828601,14.7628818 L45.4747001,14.9684791 L45.5776458,15.0805325 C45.3653289,15.2755924 45.1276565,15.4379567 44.8720021,15.5637572 L44.2599147,16.1683092 C44.0725695,15.9786289 43.820271,15.8709677 43.5483871,15.8709677 L41,15.8709677 L41,13.8709677 L40.0906769,13.8709677 L40.0906769,15.8709677 L40,15.8709677 L36,15.8709677 L36,13.8709677 L35.0906769,13.8709677 L35.0906769,15.8709677 L35,15.8709677 L31,15.8709677 L31,13.8709677 L30.0906769,13.8709677 L30.0906769,15.8709677 L30,15.8709677 L26,15.8709677 L26,13.8709677 L25.0906769,13.8709677 L25.0906769,15.8709677 L25,15.8709677 L21,15.8709677 L21,13.8709677 L20.0906769,13.8709677 L20.0906769,15.8709677 L20,15.8709677 L16,15.8709677 L16,13.8709677 L15.0906769,13.8709677 L15.0906769,15.8709677 L15,15.8709677 L11,15.8709677 L11,14.2693598 L11,13.8709677 L10.0906769,13.8709677 L10.0906769,15.8709677 L10,15.8709677 L6,15.8709677 C5.82450799,15.8709677 5.6525354,15.8558993 5.48530551,15.8269856 L5.55780255,15.9735529 C5.33170268,16.0853894 5.15915084,16.2759784 5.06924263,16.5046113 C5.21553457,16.1336993 5.57711247,15.8712015 6,15.8712015 L43.5483871,15.8712015 C44.0794266,15.8712015 44.5137871,16.285134 44.5464191,16.8079497 C44.5423817,16.7412412 44.5318088,16.6760755 44.5150104,16.6128425 L46.447964,16.0993346 C46.5144279,16.349519 46.5483871,16.6084625 46.5483871,16.8709677 L46.5483871,20.35179 L44.5483871,20.35179 L44.5483871,21.35179 L46.5483871,21.35179 L46.5483871,24.7419355 C46.5483871,24.9954726 46.5167088,25.2457145 46.4546398,25.4879835 L44.5172135,24.9916174 C44.5378173,24.9111961 44.5483871,24.8277002 44.5483871,24.7419355 L44.5483871,24.7250701 C44.5483871,25.2773548 44.1006718,25.7250701 43.5483871,25.7250701 L6,25.7250701 C5.44771525,25.7250701 5,25.2773548 5,24.7250701 L5,24.7419355 C5,25.2942202 5.44771525,25.7419355 6,25.7419355 L10,25.7419355 L10.0906769,25.7419355 L10.0906769,27.7419355 L11,27.7419355 L11,25.7419355 L15,25.7419355 L15.0906769,25.7419355 L15.0906769,27.7419355 L16,27.7419355 L16,25.7419355 L20,25.7419355 L20.0906769,25.7419355 L20.0906769,27.7419355 L21,27.7419355 L21,25.7419355 L25,25.7419355 L25.0906769,25.7419355 L25.0906769,27.7419355 L26,27.7419355 L26,25.7419355 L30,25.7419355 L30.0906769,25.7419355 L30.0906769,27.7419355 L31,27.7419355 L31,25.7419355 L35,25.7419355 L35.0906769,25.7419355 L35.0906769,27.7419355 L36,27.7419355 L36,25.7419355 L40,25.7419355 L40.0906769,25.7419355 L40.0906769,27.7419355 L41,27.7419355 L41,25.7419355 L43.5483871,25.7419355 C43.8032793,25.7419355 44.0408007,25.6475172 44.2245539,25.4786994 L44.6631978,25.9561505 C45.0438749,26.10851 45.3910707,26.3384231 45.6828601,26.6338495 L45.4747001,26.8394469 L45.5776458,26.9515003 C45.3653289,27.1465601 45.1276565,27.3089244 44.8720021,27.434725 L44.2599147,28.0392769 C44.411356,28.192618 44.5135913,28.394668 44.5410048,28.6198113 C44.5355387,28.5736004 44.5268105,28.5282285 44.5150104,28.4838102 L46.447964,27.9703024 C46.5144279,28.2204868 46.5483871,28.4794303 46.5483871,28.7419355 L46.5483871,32.2227578 L44.5483871,32.2227578 L44.5483871,33.2227578 L46.5483871,33.2227578 L46.5483871,36.6129032 C46.5483871,36.8664403 46.5167088,37.1166822 46.4546398,37.3589513 L44.5172135,36.8625852 C44.5281801,36.8197799 44.5363041,36.7761035 44.5415046,36.7316776 C44.5125843,36.9752784 44.396179,37.1920667 44.2245501,37.349663 L45.5776458,38.822468 C45.0283697,39.3270991 44.3093923,39.6129032 43.5483871,39.6129032 L41,39.6129032 L41,37.6129032 L40,37.6129032 L40,39.6129032 L36,39.6129032 L36,37.6129032 L35,37.6129032 L35,39.6129032 L31,39.6129032 L31,37.6129032 L30,37.6129032 L30,39.6129032 L26,39.6129032 L26,37.6129032 L25,37.6129032 L25,39.6129032 L21,39.6129032 L21,37.6129032 L20,37.6129032 L20,39.6129032 L16,39.6129032 L16,37.6129032 L15,37.6129032 L15,39.6129032 L11,39.6129032 L11,37.6129032 L10,37.6129032 L10,39.6129032 L6,39.6129032 Z M5.48530551,27.6979533 C4.80578744,27.5804661 4.20457609,27.2343802 3.76374069,26.7417647 Z"
            //    },
            //    Width = 43.54838562011719,
            //    Height = 46.51612854003906,
            //    OffsetX = 24.774192810058594,
            //    OffsetY = 25.25806427001953,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes255);
            //Node NetworkShapes256 = new Node()
            //{
            //    ID = "Virtual Server2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M36.6451613,32.6774194 C36.6451613,31.8583226 35.9803871,31.1935484 35.1612903,31.1935484 C34.3412043,31.1935484 33.6774194,31.8583226 33.6774194,32.6774194 C33.6774194,33.4965161 34.3412043,34.1612903 35.1612903,34.1612903 C35.9803871,34.1612903 36.6451613,33.4965161 36.6451613,32.6774194 Z M32.1935484,32.6774194 C32.1935484,31.8583226 31.5287742,31.1935484 30.7096774,31.1935484 C29.8895914,31.1935484 29.2258065,31.8583226 29.2258065,32.6774194 C29.2258065,33.4965161 29.8895914,34.1612903 30.7096774,34.1612903 C31.5287742,34.1612903 32.1935484,33.4965161 32.1935484,32.6774194 Z M36.6451613,20.8064516 C36.6451613,19.9873548 35.9803871,19.3225806 35.1612903,19.3225806 C34.3412043,19.3225806 33.6774194,19.9873548 33.6774194,20.8064516 C33.6774194,21.6255484 34.3412043,22.2903226 35.1612903,22.2903226 C35.9803871,22.2903226 36.6451613,21.6255484 36.6451613,20.8064516 Z M32.1935484,20.8064516 C32.1935484,19.9873548 31.5287742,19.3225806 30.7096774,19.3225806 C29.8895914,19.3225806 29.2258065,19.9873548 29.2258065,20.8064516 C29.2258065,21.6255484 29.8895914,22.2903226 30.7096774,22.2903226 C31.5287742,22.2903226 32.1935484,21.6255484 32.1935484,20.8064516 Z M36.6451613,8.93548387 C36.6451613,8.1163871 35.9803871,7.4516129 35.1612903,7.4516129 C34.3412043,7.4516129 33.6774194,8.1163871 33.6774194,8.93548387 C33.6774194,9.75458065 34.3412043,10.4193548 35.1612903,10.4193548 C35.9803871,10.4193548 36.6451613,9.75458065 36.6451613,8.93548387 Z M32.1935484,8.93548387 C32.1935484,8.1163871 31.5287742,7.4516129 30.7096774,7.4516129 C29.8895914,7.4516129 29.2258065,8.1163871 29.2258065,8.93548387 C29.2258065,9.75458065 29.8895914,10.4193548 30.7096774,10.4193548 C31.5287742,10.4193548 32.1935484,9.75458065 32.1935484,8.93548387 Z M6,13.8709677 C5.44771525,13.8709677 5,13.4232525 5,12.8709677 L5,5 C5,4.44771525 5.44771525,4 6,4 L43.5483871,4 C44.1006718,4 44.5483871,4.44771525 44.5483871,5 L44.5483871,12.8709677 C44.5483871,13.4232525 44.1006718,13.8709677 43.5483871,13.8709677 L6,13.8709677 Z M6,25.7419355 C5.44771525,25.7419355 5,25.2942202 5,24.7419355 L5,16.8709677 C5,16.318683 5.44771525,15.8709677 6,15.8709677 L43.5483871,15.8709677 C44.1006718,15.8709677 44.5483871,16.318683 44.5483871,16.8709677 L44.5483871,24.7419355 C44.5483871,25.2942202 44.1006718,25.7419355 43.5483871,25.7419355 L6,25.7419355 Z M6,37.6129032 C5.44771525,37.6129032 5,37.165188 5,36.6129032 L5,28.7419355 C5,28.1896507 5.44771525,27.7419355 6,27.7419355 L43.5483871,27.7419355 C44.1006718,27.7419355 44.5483871,28.1896507 44.5483871,28.7419355 L44.5483871,36.6129032 C44.5483871,37.165188 44.1006718,37.6129032 43.5483871,37.6129032 L6,37.6129032 Z M41.0967742,8.93548387 C41.0967742,8.1163871 40.432,7.4516129 39.6129032,7.4516129 C38.7928172,7.4516129 38.1290323,8.1163871 38.1290323,8.93548387 C38.1290323,9.75458065 38.7928172,10.4193548 39.6129032,10.4193548 C40.432,10.4193548 41.0967742,9.75458065 41.0967742,8.93548387 Z M41.0967742,20.8064516 C41.0967742,19.9873548 40.432,19.3225806 39.6129032,19.3225806 C38.7928172,19.3225806 38.1290323,19.9873548 38.1290323,20.8064516 C38.1290323,21.6255484 38.7928172,22.2903226 39.6129032,22.2903226 C40.432,22.2903226 41.0967742,21.6255484 41.0967742,20.8064516 Z M41.0967742,32.6774194 C41.0967742,31.8583226 40.432,31.1935484 39.6129032,31.1935484 C38.7928172,31.1935484 38.1290323,31.8583226 38.1290323,32.6774194 C38.1290323,33.4965161 38.7928172,34.1612903 39.6129032,34.1612903 C40.432,34.1612903 41.0967742,33.4965161 41.0967742,32.6774194 Z"
            //    },
            //    Width = 39.54838562011719,
            //    Height = 33.6129035949707,
            //    OffsetX = 24.774192810058594,
            //    OffsetY = 20.80645179748535,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes256);
            //Node NetworkShapes257 = new Node()
            //{
            //    ID = "Virtual Server3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M32.1935484,32.6774194 C32.1935484,33.4965161 31.5287742,34.1612903 30.7096774,34.1612903 C29.8895914,34.1612903 29.2258065,33.4965161 29.2258065,32.6774194 C29.2258065,31.8583226 29.8895914,31.1935484 30.7096774,31.1935484 C31.5287742,31.1935484 32.1935484,31.8583226 32.1935484,32.6774194 Z M32.1935484,20.8064516 C32.1935484,21.6255484 31.5287742,22.2903226 30.7096774,22.2903226 C29.8895914,22.2903226 29.2258065,21.6255484 29.2258065,20.8064516 C29.2258065,19.9873548 29.8895914,19.3225806 30.7096774,19.3225806 C31.5287742,19.3225806 32.1935484,19.9873548 32.1935484,20.8064516 Z M32.1935484,8.93548387 C32.1935484,9.75458065 31.5287742,10.4193548 30.7096774,10.4193548 C29.8895914,10.4193548 29.2258065,9.75458065 29.2258065,8.93548387 C29.2258065,8.1163871 29.8895914,7.4516129 30.7096774,7.4516129 C31.5287742,7.4516129 32.1935484,8.1163871 32.1935484,8.93548387 Z"
            //    },
            //    Width = 2.967742919921875,
            //    Height = 26.70967674255371,
            //    OffsetX = 30.709678649902344,
            //    OffsetY = 20.806451320648193,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes257);
            //Node NetworkShapes258 = new Node()
            //{
            //    ID = "Virtual Server4",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M36.6451613,32.6774194 C36.6451613,33.4965161 35.9803871,34.1612903 35.1612903,34.1612903 C34.3412043,34.1612903 33.6774194,33.4965161 33.6774194,32.6774194 C33.6774194,31.8583226 34.3412043,31.1935484 35.1612903,31.1935484 C35.9803871,31.1935484 36.6451613,31.8583226 36.6451613,32.6774194 Z M36.6451613,20.8064516 C36.6451613,21.6255484 35.9803871,22.2903226 35.1612903,22.2903226 C34.3412043,22.2903226 33.6774194,21.6255484 33.6774194,20.8064516 C33.6774194,19.9873548 34.3412043,19.3225806 35.1612903,19.3225806 C35.9803871,19.3225806 36.6451613,19.9873548 36.6451613,20.8064516 Z M36.6451613,8.93548387 C36.6451613,9.75458065 35.9803871,10.4193548 35.1612903,10.4193548 C34.3412043,10.4193548 33.6774194,9.75458065 33.6774194,8.93548387 C33.6774194,8.1163871 34.3412043,7.4516129 35.1612903,7.4516129 C35.9803871,7.4516129 36.6451613,8.1163871 36.6451613,8.93548387 Z"
            //    },
            //    Width = 2.967742919921875,
            //    Height = 26.70967674255371,
            //    OffsetX = 35.16128921508789,
            //    OffsetY = 20.806451320648193,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes258);
            //Node NetworkShapes259 = new Node()
            //{
            //    ID = "Virtual Server5",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M8.4516129,9.93548387 L8.4516129,7.93548387 L24.7741935,7.93548387 L24.7741935,9.93548387 L8.4516129,9.93548387 Z M8.4516129,21.8064516 L8.4516129,19.8064516 L24.7741935,19.8064516 L24.7741935,21.8064516 L8.4516129,21.8064516 Z M8.4516129,33.6774194 L8.4516129,31.6774194 L24.7741935,31.6774194 L24.7741935,33.6774194 L8.4516129,33.6774194 Z"
            //    },
            //    Width = 16.322580337524414,
            //    Height = 25.741933822631836,
            //    OffsetX = 16.612902641296387,
            //    OffsetY = 20.806450843811035,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes259);
            //NodeGroup NetworkShapes260 = new NodeGroup()
            //{
            //    ID = "Virtual Server",
            //    Children = new string[] {
            //   "Virtual Server1",
            //   "Virtual Server2",
            //   "Virtual Server3",
            //   "Virtual Server4",
            //   "Virtual Server5"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes260);
            //Node NetworkShapes261 = new Node()
            //{
            //    ID = "Web Sever1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M32.3125,31.2516105 L32.3125,39.375 C32.3125,40.4795695 31.4170695,41.375 30.3125,41.375 L19.375,41.375 L19.375,46.5625 L31.3125,46.5625 C31.8647847,46.5625 32.3125,47.0102153 32.3125,47.5625 C32.3125,48.1147847 31.8647847,48.5625 31.3125,48.5625 L5.4375,48.5625 C4.88521525,48.5625 4.4375,48.1147847 4.4375,47.5625 C4.4375,47.0102153 4.88521525,46.5625 5.4375,46.5625 L17.375,46.5625 L17.375,41.375 L5,41.375 C3.8954305,41.375 3,40.4795695 3,39.375 L3,29.875 C3,29.5107129 3.09739429,29.1691734 3.26756439,28.875 C3.09739429,28.5808266 3,28.2392871 3,27.875 L3,18.375 C3,18.0107129 3.09739429,17.6691734 3.26756439,17.375 C3.09739429,17.0808266 3,16.7392871 3,16.375 L3,6.875 C3,5.7704305 3.8954305,4.875 5,4.875 L24.940606,4.875 C27.3772524,3.06872917 30.3928615,2 33.65625,2 C41.7456253,2 48.3125,8.56689513 48.3125,16.65625 C48.3125,24.7456656 41.7456558,31.3125 33.65625,31.3125 C33.2032638,31.3125 32.7550519,31.2919083 32.3125,31.2516105 Z"
            //    },
            //    Width = 45.3125,
            //    Height = 46.5625,
            //    OffsetX = 25.65625,
            //    OffsetY = 25.28125,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes261);
            //Node NetworkShapes262 = new Node()
            //{
            //    ID = "Web Sever2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M22.6875,34.625 C22.6875,35.4185 22.0435,36.0625 21.25,36.0625 C20.4555417,36.0625 19.8125,35.4185 19.8125,34.625 C19.8125,33.8315 20.4555417,33.1875 21.25,33.1875 C22.0435,33.1875 22.6875,33.8315 22.6875,34.625"
            //    },
            //    Width = 2.875,
            //    Height = 2.875,
            //    OffsetX = 21.25,
            //    OffsetY = 34.625,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes262);
            //Node NetworkShapes263 = new Node()
            //{
            //    ID = "Web Sever3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M27,34.625 C27,35.4185 26.356,36.0625 25.5625,36.0625 C24.7680417,36.0625 24.125,35.4185 24.125,34.625 C24.125,33.8315 24.7680417,33.1875 25.5625,33.1875 C26.356,33.1875 27,33.8315 27,34.625"
            //    },
            //    Width = 2.875,
            //    Height = 2.875,
            //    OffsetX = 25.5625,
            //    OffsetY = 34.625,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes263);
            //Node NetworkShapes264 = new Node()
            //{
            //    ID = "Web Sever4",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M8.3125,12.625 L8.3125,10.625 L16.9375,10.625 L16.9375,12.625 L8.3125,12.625 Z M8.3125,24.125 L8.3125,22.125 L16.9375,22.125 L16.9375,24.125 L8.3125,24.125 Z M8.3125,35.625 L8.3125,33.625 L16.9375,33.625 L16.9375,35.625 L8.3125,35.625 Z"
            //    },
            //    Width = 8.625,
            //    Height = 25,
            //    OffsetX = 12.625,
            //    OffsetY = 23.125,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes264);
            //Node NetworkShapes265 = new Node()
            //{
            //    ID = "Web Sever5",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M29.1232301,21.7256944 C28.7374587,20.3101089 28.5007835,18.9263883 28.4009072,17.5763889 L38.5365928,17.5763889 C38.4367165,18.9263883 38.2000413,20.3101089 37.8142699,21.7256944 L29.1232301,21.7256944 Z M29.761075,23.7256944 L37.176425,23.7256944 C36.5184321,25.5282533 35.6194705,27.3790588 34.4556634,29.2745068 C34.1299736,29.2996795 33.8008463,29.3125 33.46875,29.3125 C33.1366537,29.3125 32.8075264,29.2996795 32.4818366,29.2745068 C31.3180295,27.3790588 30.4190679,25.5282533 29.761075,23.7256944 Z M45.067175,21.7256944 L39.8808479,21.7256944 C40.2334059,20.315194 40.450384,18.9312261 40.5418555,17.5763889 L46.0919911,17.5763889 C45.9864323,19.0424809 45.6306465,20.4397631 45.067175,21.7256944 Z M43.9652853,23.7256944 C42.3372482,26.1368565 39.9006535,27.9580905 37.0459267,28.7989734 C37.9934426,27.0767275 38.737914,25.3842966 39.294902,23.7256944 L43.9652853,23.7256944 Z M21.870325,21.7256944 C21.3068535,20.4397631 20.9510677,19.0424809 20.8455089,17.5763889 L26.3956445,17.5763889 C26.487116,18.9312261 26.7040941,20.315194 27.0566521,21.7256944 L21.870325,21.7256944 Z M22.9722137,23.7256944 L27.642598,23.7256944 C28.199586,25.3842966 28.9440574,27.0767275 29.8915733,28.7989734 C27.036847,27.9580907 24.6002527,26.1368572 22.9722156,23.7256958 Z M28.3521682,15.5763889 C28.3881222,14.1801529 28.5711854,12.822932 28.8866645,11.5069444 L38.0508355,11.5069444 C38.3663146,12.822932 38.5493778,14.1801529 38.5853318,15.5763889 L28.3521682,15.5763889 Z M46.079479,15.5763889 L40.5864296,15.5763889 C40.5539898,14.185387 40.3887937,12.8279039 40.1024906,11.5069444 L45.0318345,11.5069444 C45.5949629,12.7682038 45.9577038,14.1382114 46.079479,15.5763889 Z M20.858021,15.5763889 C20.9797962,14.1382114 21.3425371,12.7682038 21.9056655,11.5069444 L26.8350094,11.5069444 C26.5487063,12.8279039 26.3835102,14.185387 26.3510704,15.5763889 L20.858021,15.5763889 Z M29.4774015,9.50694444 C29.7840813,8.6354871 30.1492763,7.78389055 30.5682721,6.95286648 C31.0417607,6.01376304 31.5480115,5.18968022 32.0520366,4.48869293 C32.1755003,4.31698233 32.2864591,4.16925239 32.3823526,4.04607605 C32.7404622,4.0155676 33.1028036,4 33.46875,4 C33.8346964,4 34.1970378,4.0155676 34.5551474,4.04607605 C34.6510409,4.16925239 34.7619997,4.31698233 34.8854634,4.48869293 C35.3894885,5.18968022 35.8957393,6.01376304 36.3692279,6.95286648 C36.7882237,7.78389055 37.1534187,8.6354871 37.4600985,9.50694444 L29.4774015,9.50694444 Z M43.9108924,9.50694444 L39.5690082,9.50694444 C39.192857,8.32219129 38.7184875,7.16990578 38.1550777,6.0524551 C37.8973944,5.54137367 37.6303724,5.0602944 37.3583519,4.61000372 C40.0470351,5.47872298 42.3435909,7.22341355 43.9108924,9.50694444 Z M23.0266076,9.50694444 C24.5939091,7.22341355 26.8904649,5.47872298 29.5791481,4.61000372 C29.3071276,5.0602944 29.0401056,5.54137367 28.7824223,6.0524551 C28.2190125,7.16990578 27.744643,8.32219129 27.3684918,9.50694444 L23.0266076,9.50694444 Z M22.7448363,6.875 C20.4749952,9.40505655 19.0714265,12.7278984 19.0026499,16.375 L5,16.375 L5,6.875 L22.7448363,6.875 Z M27.3222558,29.875 C28.2673566,30.3290739 29.2685419,30.6847509 30.3125,30.9287192 L30.3125,39.375 L5,39.375 L5,29.875 L27.3222558,29.875 Z M19.0998932,18.375 C19.5445657,22.175258 21.4453304,25.5330947 24.2286737,27.875 L5,27.875 L5,18.375 L19.0998932,18.375 Z M22.6875,34.625 C22.6875,33.8315 22.0435,33.1875 21.25,33.1875 C20.4555417,33.1875 19.8125,33.8315 19.8125,34.625 C19.8125,35.4185 20.4555417,36.0625 21.25,36.0625 C22.0435,36.0625 22.6875,35.4185 22.6875,34.625 Z M27,34.625 C27,33.8315 26.356,33.1875 25.5625,33.1875 C24.7680417,33.1875 24.125,33.8315 24.125,34.625 C24.125,35.4185 24.7680417,36.0625 25.5625,36.0625 C26.356,36.0625 27,35.4185 27,34.625 Z"
            //    },
            //    Width = 41.09199142456055,
            //    Height = 35.375,
            //    OffsetX = 25.545995712280273,
            //    OffsetY = 21.6875,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes265);
            //NodeGroup NetworkShapes266 = new NodeGroup()
            //{
            //    ID = "Web Sever",
            //    Children = new string[] {
            //   "Web Sever1",
            //   "Web Sever2",
            //   "Web Sever3",
            //   "Web Sever4",
            //   "Web Sever5"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes266);
            //Node NetworkShapes267 = new Node()
            //{
            //    ID = "Wireless Modem1",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M36.9375,18.625 L36.9375,11 C36.9375,10.4477153 37.3852153,10 37.9375,10 C38.4897847,10 38.9375,10.4477153 38.9375,11 L38.9375,18.625 L47.9,18.625 C48.5075132,18.625 49,19.1174868 49,19.725 L49,36.775 C49,37.3825132 48.5075132,37.875 47.9,37.875 L43.25,37.875 L43.25,39.74 C43.0239038,40.5239038 43.0239038,40.5239038 42.24,40.75 L35.0725,40.75 C34.2885962,40.5239038 34.2885962,40.5239038 34.0625,39.74 L34.0625,37.875 L15.9375,37.875 L15.9375,39.74 C15.7114038,40.5239038 15.7114038,40.5239038 14.9275,40.75 L7.76,40.75 C6.9760962,40.5239038 6.9760962,40.5239038 6.75,39.74 L6.75,37.875 L2.1,37.875 C1.49248678,37.875 1,37.3825132 1,36.775 L1,19.725 C1,19.1174868 1.49248678,18.625 2.1,18.625 L11.0625,18.625 L11.0625,11 C11.0625,10.4477153 11.5102153,10 12.0625,10 C12.6147847,10 13.0625,10.4477153 13.0625,11 L13.0625,18.625 L36.9375,18.625 Z M8.75,37.875 L8.75,38.75 L13.9375,38.75 L13.9375,37.875 L8.75,37.875 Z M36.0625,37.875 L36.0625,38.75 L41.25,38.75 L41.25,37.875 L36.0625,37.875 Z"
            //    },
            //    Width = 48,
            //    Height = 30.75,
            //    OffsetX = 25,
            //    OffsetY = 25.375,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes267);
            //Node NetworkShapes268 = new Node()
            //{
            //    ID = "Wireless Modem2",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M3,35.875 L3,20.625 L47,20.625 L47,35.875 L3,35.875 Z M35.0625,28.25 C35.0625,27.4565 34.4185,26.8125 33.625,26.8125 C32.8305417,26.8125 32.1875,27.4565 32.1875,28.25 C32.1875,29.0435 32.8305417,29.6875 33.625,29.6875 C34.4185,29.6875 35.0625,29.0435 35.0625,28.25 Z M9.1875,28.25 C9.1875,27.4565 8.5435,26.8125 7.75,26.8125 C6.95554167,26.8125 6.3125,27.4565 6.3125,28.25 C6.3125,29.0435 6.95554167,29.6875 7.75,29.6875 C8.5435,29.6875 9.1875,29.0435 9.1875,28.25 Z M39.375,28.25 C39.375,27.4565 38.731,26.8125 37.9375,26.8125 C37.1430417,26.8125 36.5,27.4565 36.5,28.25 C36.5,29.0435 37.1430417,29.6875 37.9375,29.6875 C38.731,29.6875 39.375,29.0435 39.375,28.25 Z M43.6875,28.25 C43.6875,27.4565 43.0435,26.8125 42.25,26.8125 C41.4555417,26.8125 40.8125,27.4565 40.8125,28.25 C40.8125,29.0435 41.4555417,29.6875 42.25,29.6875 C43.0435,29.6875 43.6875,29.0435 43.6875,28.25 Z"
            //    },
            //    Width = 44,
            //    Height = 15.25,
            //    OffsetX = 25,
            //    OffsetY = 28.25,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes268);
            //Node NetworkShapes269 = new Node()
            //{
            //    ID = "Wireless Modem3",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M35.0625,28.25 C35.0625,29.0435 34.4185,29.6875 33.625,29.6875 C32.8305417,29.6875 32.1875,29.0435 32.1875,28.25 C32.1875,27.4565 32.8305417,26.8125 33.625,26.8125 C34.4185,26.8125 35.0625,27.4565 35.0625,28.25"
            //    },
            //    Width = 2.875,
            //    Height = 2.875,
            //    OffsetX = 33.625,
            //    OffsetY = 28.25,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes269);
            //Node NetworkShapes270 = new Node()
            //{
            //    ID = "Wireless Modem4",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M39.375,28.25 C39.375,29.0435 38.731,29.6875 37.9375,29.6875 C37.1430417,29.6875 36.5,29.0435 36.5,28.25 C36.5,27.4565 37.1430417,26.8125 37.9375,26.8125 C38.731,26.8125 39.375,27.4565 39.375,28.25"
            //    },
            //    Width = 2.875,
            //    Height = 2.875,
            //    OffsetX = 37.9375,
            //    OffsetY = 28.25,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes270);
            //Node NetworkShapes271 = new Node()
            //{
            //    ID = "Wireless Modem5",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M12.0625 29.25 12.0625 27.25 27.875 27.25 27.875 29.25"
            //    },
            //    Width = 15.8125,
            //    Height = 2,
            //    OffsetX = 19.96875,
            //    OffsetY = 28.25,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //NetworkShapesList.Add(NetworkShapes271);
            //NodeGroup NetworkShapes272 = new NodeGroup()
            //{
            //    ID = "Wireless Modem",
            //    Children = new string[] {
            //   "Wireless Modem1",
            //   "Wireless Modem2",
            //   "Wireless Modem3",
            //   "Wireless Modem4",
            //   "Wireless Modem5"
            //}
            //};
            //NetworkShapesList.Add(NetworkShapes272);
            NetworkShapes = new Palette() { ID = "NetworkShapes", IsExpanded = false, Symbols = NetworkShapesList, Title = "Network Shapes" };
        }


        //private void CreatePath(string id, string data, string fill, double width, double height, double x, double y)
        //{
        //    DiagramNode Nodes11 = new DiagramNode()
        //    {
        //        Id = id,
        //        Shape = new DiagramShape()
        //        {
        //            Type = DiagramShapes.Path,
        //            Data = data
        //        },
        //        Style = new NodeShapeStyle() { Fill = fill, StrokeColor = "#000" },
        //        Width = width,
        //        Height = height,
        //        OffsetX = x,
        //        OffsetY = y,
        //        Constraints = NodeConstraints.Default & ~NodeConstraints.Select
        //    };
        //    ElectricalCapacitorsList.Add(Nodes11);

        //    DiagramNode Nodes0 = new DiagramNode()
        //    {
        //        Id = "CapacitorUK1",
        //        Shape = new DiagramShape() { Type = DiagramShapes.Path, Data = "M 57.5 , 49.5 L 99.5 , 49.5" },
        //        Style = new NodeShapeStyle() { Fill = "none", StrokeColor = "#000" },
        //        Width = 42,
        //        Height = 1,
        //        OffsetX = 78.5,
        //        OffsetY = 50,
        //        Constraints = NodeConstraints.Default & ~NodeConstraints.Select
        //    };
        //    ElectricalCapacitorsList.Add(Nodes0);
        //    ElectricalGatesList = new ObservableCollection<object>();
        //}
        public void InitializeFloorShapes()
        {

            FloorPlaneShapesList = new DiagramObjectCollection<NodeBase>();
            //Node FloorPlaneShapes1214 = new Node()
            //{
            //    ID = "WesternToilet2ejhIJI",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M104.14 , 126.31l-3.49.52a99.9,99.9 , 0 , 0 , 1-29.3 , 0l-3.49-.52a15.15 , 15.15 , 0 , 0 , 1-12-9.71h0a100 , 100 , 0 , 0 , 1-4.31-54.43L53 , 55h66l1.43 , 7.17a100 , 100 , 0 , 0 , 1-4.31 , 54.43h0A15.15 , 15.15 , 0 , 0 , 1 , 104.14 , 126.31Z"
            //    },
            //    Style = new ShapeStyle()
            //    {
            //        Fill = "#7f7f7f",
            //        StrokeWidth = 0
            //    },
            //    Width = 72.76765441894531,
            //    Height = 72.91001892089844,
            //    OffsetX = 85.99000930786133,
            //    OffsetY = 91.45500946044922,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //FloorPlaneShapesList.Add(FloorPlaneShapes1214);
            //Node FloorPlaneShapes1215 = new Node()
            //{
            //    ID = "WesternToilet3KTKBGm",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M102.24,66.88a3.76,3.76,0,0,1,7.52,0"
            //    },
            //    Style = new ShapeStyle()
            //    {
            //        Fill = "#aaa",
            //        StrokeWidth = 0
            //    },
            //    Width = 7.519996643066406,
            //    Height = 3.759998321533203,
            //    OffsetX = 105.99999618530273,
            //    OffsetY = 64.99999809265137,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //FloorPlaneShapesList.Add(FloorPlaneShapes1215);
            //Node FloorPlaneShapes1216 = new Node()
            //{
            //    ID = "WesternToilet46UeEKg",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M63.34,66.88a3.76,3.76,0,0,1,7.52,0"
            //    },
            //    Style = new ShapeStyle()
            //    {
            //        Fill = "#aaa",
            //        StrokeWidth = 0
            //    },
            //    Width = 7.520000457763672,
            //    Height = 3.759998321533203,
            //    OffsetX = 67.10000038146973,
            //    OffsetY = 64.99999809265137,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //FloorPlaneShapesList.Add(FloorPlaneShapes1216);
            //Node FloorPlaneShapes1217 = new Node()
            //{
            //    ID = "WesternToilet5Qhlt74",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M100.37,123.48l-2.76.41a79.25,79.25,0,0,1-23.22,0l-2.76-.41a12,12,0,0,1-9.49-7.69h0a79.18,79.18,0,0,1-3.41-43.11L59.86,67h52.28l1.13,5.68a79.18,79.18,0,0,1-3.41,43.11h0A12,12,0,0,1,100.37,123.48Z"
            //    },
            //    Style = new ShapeStyle()
            //    {
            //        Fill = "#dbdcdd",
            //        StrokeWidth = 0
            //    },
            //    Width = 57.623321533203125,
            //    Height = 57.74504089355469,
            //    OffsetX = 86,
            //    OffsetY = 95.87252044677734,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //FloorPlaneShapesList.Add(FloorPlaneShapes1217);
            //Node FloorPlaneShapes1218 = new Node()
            //{
            //    ID = "WesternToilet62T4DMx",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M124.87,56.43h0a195.15,195.15,0,0,1-78.74,0h0a4.75,4.75,0,0,1-3.79-4.66V33.7A4.75,4.75,0,0,1,47.09,29h76.82a4.75,4.75,0,0,1,4.75,4.75V51.77A4.75,4.75,0,0,1,124.87,56.43Z"
            //    },
            //    Style = new ShapeStyle()
            //    {
            //        Fill = "#dbdcdd",
            //        StrokeWidth = 0
            //    },
            //    Width = 86.32000732421875,
            //    Height = 31.44255828857422,
            //    OffsetX = 85.50000381469727,
            //    OffsetY = 44.72127914428711,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //FloorPlaneShapesList.Add(FloorPlaneShapes1218);
            //Node FloorPlaneShapes1219 = new Node()
            //{
            //    ID = "WesternToilet7Efn1WE",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M57.84,78.09a79.28,79.28,0,0,0,4.3,37.7,12,12,0,0,0,9.49,7.69l2.76.41a79.25,79.25,0,0,0,23.22,0l2.76-.41a12,12,0,0,0,9.49-7.69,79.22,79.22,0,0,0,4.3-37.69C98.79,75.68,78.34,74.25,57.84,78.09Z"
            //    },
            //    Style = new ShapeStyle()
            //    {
            //        Fill = "#fff",
            //        StrokeWidth = 0
            //    },
            //    Width = 57.619293212890625,
            //    Height = 49.02782440185547,
            //    OffsetX = 86.0002212524414,
            //    OffsetY = 100.23112869262695,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //FloorPlaneShapesList.Add(FloorPlaneShapes1219);
            //Node FloorPlaneShapes1220 = new Node()
            //{
            //    ID = "WesternToilet8xrYXIk",
            //    Shape = new BasicShape()
            //    {
            //        Type = Shapes.Basic,
            //        Shape = BasicShapeType.Ellipse
            //    },
            //    Style = new ShapeStyle()
            //    {
            //        Fill = "#fff"
            //    },
            //    Width = 13,
            //    Height = 13,
            //    OffsetX = 85.5,
            //    OffsetY = 44.70000076293945,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //FloorPlaneShapesList.Add(FloorPlaneShapes1220);
            //Node FloorPlaneShapes1221 = new Node()
            //{
            //    ID = "WesternToilet95jp9aq",
            //    Shape = new BasicShape()
            //    {
            //        Type = Shapes.Basic,
            //        Shape = BasicShapeType.Ellipse
            //    },
            //    Style = new ShapeStyle()
            //    {
            //        Fill = "#7f7f7f"
            //    },
            //    Width = 9,
            //    Height = 9,
            //    OffsetX = 85.5,
            //    OffsetY = 44.70000076293945,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //FloorPlaneShapesList.Add(FloorPlaneShapes1221);
            //NodeGroup FloorPlaneShapes1222 = new NodeGroup()
            //{
            //    ID = "Western Toilet",
            //    Children = new string[] {
            //   "WesternToilet2ejhIJI",
            //   "WesternToilet3KTKBGm",
            //   "WesternToilet46UeEKg",
            //   "WesternToilet5Qhlt74",
            //   "WesternToilet62T4DMx",
            //   "WesternToilet7Efn1WE",
            //   "WesternToilet8xrYXIk",
            //   "WesternToilet95jp9aq"
            //}
            //};
            //FloorPlaneShapesList.Add(FloorPlaneShapes1222);
            //Node FloorPlaneShapes1223 = new Node()
            //{
            //    ID = "Window2fCDmck",
            //    Shape = new PathShape()
            //    {
            //        Type = Shapes.Path,
            //        Data = "M 43.5 , 82.5 L 122.5 , 82.5"
            //    },
            //    Style = new ShapeStyle()
            //    {
            //        Fill = "none",
            //        StrokeColor = "#464747"
            //    },
            //    Width = 79,
            //    Height = 1,
            //    OffsetX = 83,
            //    OffsetY = 83,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //FloorPlaneShapesList.Add(FloorPlaneShapes1223);
            //Node FloorPlaneShapes1224 = new Node()
            //{
            //    ID = "Window3uNXEd7",
            //    Shape = new BasicShape()
            //    {
            //        Type = Shapes.Basic,
            //        Shape = BasicShapeType.Rectangle
            //    },
            //    Style = new ShapeStyle()
            //    {
            //        Fill = "none",
            //        StrokeColor = "#464747"
            //    },
            //    Width = 6,
            //    Height = 6,
            //    OffsetX = 40.5,
            //    OffsetY = 82.5,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //FloorPlaneShapesList.Add(FloorPlaneShapes1224);
            //Node FloorPlaneShapes1225 = new Node()
            //{
            //    ID = "Window4bK3fDw",
            //    Shape = new BasicShape()
            //    {
            //        Type = Shapes.Basic,
            //        Shape = BasicShapeType.Rectangle
            //    },
            //    Style = new ShapeStyle()
            //    {
            //        Fill = "none",
            //        StrokeColor = "#464747"
            //    },
            //    Width = 6,
            //    Height = 6,
            //    OffsetX = 125.5,
            //    OffsetY = 82.5,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //FloorPlaneShapesList.Add(FloorPlaneShapes1225);
            //Node FloorPlaneShapes1226 = new Node()
            //{
            //    ID = "Window5GxztBi",
            //    Shape = new BasicShape()
            //    {
            //        Type = Shapes.Basic,
            //        Shape = BasicShapeType.Rectangle
            //    },
            //    Style = new ShapeStyle()
            //    {
            //        Fill = "none",
            //        StrokeColor = "#464747"
            //    },
            //    Width = 4,
            //    Height = 14,
            //    OffsetX = 130.5,
            //    OffsetY = 82.5,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //FloorPlaneShapesList.Add(FloorPlaneShapes1226);
            //Node FloorPlaneShapes1227 = new Node()
            //{
            //    ID = "Window6EfrhSt",
            //    Shape = new BasicShape()
            //    {
            //        Type = Shapes.Basic,
            //        Shape = BasicShapeType.Rectangle
            //    },
            //    Style = new ShapeStyle()
            //    {
            //        Fill = "none",
            //        StrokeColor = "#464747"
            //    },
            //    Width = 4,
            //    Height = 14,
            //    OffsetX = 35.5,
            //    OffsetY = 82.5,
            //    Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            //};
            //FloorPlaneShapesList.Add(FloorPlaneShapes1227);
            //NodeGroup FloorPlaneShapes1228 = new NodeGroup()
            //{
            //    ID = "Window",
            //    Children = new string[] {
            //   "Window2fCDmck",
            //   "Window3uNXEd7",
            //   "Window4bK3fDw",
            //   "Window5GxztBi",
            //   "Window6EfrhSt"
            //}
            //};
            //FloorPlaneShapesList.Add(FloorPlaneShapes1228);
            Node FloorPlaneShapes1200 = new Node()
            {
                ID = "WashBasin_Mirror2siLuxk",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M0,32H160a0,0,0,0,1,0,0v79a10,10,0,0,1-10,10H10A10,10,0,0,1,0,111V32A0,0,0,0,1,0,32Z"
                },
                Style = new ShapeStyle()
                {
                    Fill = "#270805",
                    StrokeWidth = 0
                },
                Width = 160,
                Height = 89,
                OffsetX = 80,
                OffsetY = 76.5,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1200);
            Node FloorPlaneShapes1201 = new Node()
            {
                ID = "WashBasin_Mirror3Q9PxVP",
                Shape = new BasicShape()
                {
                    Type = Shapes.Basic,
                    Shape = BasicShapeType.Rectangle
                },
                Style = new ShapeStyle()
                {
                    Fill = "#dbdcdd"
                },
                Width = 160,
                Height = 7.819999694824219,
                OffsetX = 80,
                OffsetY = 35.90999984741211,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1201);
            Node FloorPlaneShapes1202 = new Node()
            {
                ID = "WashBasin_Mirror4a4GtBc",
                Shape = new BasicShape()
                {
                    Type = Shapes.Basic,
                    Shape = BasicShapeType.Rectangle
                },
                Style = new ShapeStyle()
                {
                    Fill = "#c2c3c4"
                },
                Width = 160,
                Height = 7.819999694824219,
                OffsetX = 80,
                OffsetY = 43.72999954223633,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1202);
            Node FloorPlaneShapes1203 = new Node()
            {
                ID = "WashBasin_Mirror5Ec581y",
                Shape = new BasicShape()
                {
                    Type = Shapes.Basic,
                    Shape = BasicShapeType.Ellipse,
                    CornerRadius = 44.5
                },
                Style = new ShapeStyle()
                {
                    Fill = "#dbdcdd"
                },
                Width = 89,
                Height = 48,
                OffsetX = 81.5,
                OffsetY = 85,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1203);
            Node FloorPlaneShapes1204 = new Node()
            {
                ID = "WashBasin_Mirror6xYjsZx",
                Shape = new BasicShape()
                {
                    Type = Shapes.Basic,
                    Shape = BasicShapeType.Ellipse,
                    CornerRadius = 40.5
                },
                Style = new ShapeStyle()
                {
                    Fill = "#7f7f7f"
                },
                Width = 81,
                Height = 42,
                OffsetX = 81.5,
                OffsetY = 85,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1204);
            Node FloorPlaneShapes1205 = new Node()
            {
                ID = "WashBasin_Mirror7H0IdfR",
                Shape = new BasicShape()
                {
                    Type = Shapes.Basic,
                    Shape = BasicShapeType.Ellipse
                },
                Style = new ShapeStyle()
                {
                    Fill = "#fcfcfc"
                },
                Width = 6.420000076293945,
                Height = 6.420000076293945,
                OffsetX = 81.59999942779541,
                OffsetY = 77.32000064849854,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1205);
            Node FloorPlaneShapes1206 = new Node()
            {
                ID = "WashBasin_Mirror8JGH6zw",
                Shape = new BasicShape()
                {
                    Type = Shapes.Basic,
                    Shape = BasicShapeType.Rectangle,
                    CornerRadius = 1
                },
                Style = new ShapeStyle()
                {
                    Fill = "#2080ce"
                },
                Width = 7.4599995613098145,
                Height = 10.529999732971191,
                OffsetX = 146.5499918460846,
                OffsetY = 86.38500261306763,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1206);
            Node FloorPlaneShapes1207 = new Node()
            {
                ID = "WashBasin_Mirror9K7WbYf",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M81.09,53.8h0a2.18,2.18,0,0,1,2.17,2.29l-.63,11.68a1.55,1.55,0,0,1-1.54,1.46h0a1.55,1.55,0,0,1-1.54-1.46l-.63-11.68A2.17,2.17,0,0,1,81.09,53.8Z"
                },
                Style = new ShapeStyle()
                {
                    Fill = "#fff",
                    StrokeWidth = 0
                },
                Width = 4.346092224121094,
                Height = 15.430004119873047,
                OffsetX = 81.08972549438477,
                OffsetY = 61.51500129699707,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1207);
            Node FloorPlaneShapes1208 = new Node()
            {
                ID = "WashBasin_Mirror10UE5NjR",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M87.65,56.31h0a2.18,2.18,0,0,1,2.29-2.17l11.68.63a1.54,1.54,0,0,1,1.45,1.54h0a1.54,1.54,0,0,1-1.45,1.54l-11.68.63A2.17,2.17,0,0,1,87.65,56.31Z"
                },
                Style = new ShapeStyle()
                {
                    Fill = "#fff",
                    StrokeWidth = 0
                },
                Width = 15.420013427734375,
                Height = 4.346099853515625,
                OffsetX = 95.36000061035156,
                OffsetY = 56.310272216796875,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1208);
            Node FloorPlaneShapes1209 = new Node()
            {
                ID = "WashBasin_Mirror116kqZx9",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M74.91,56.31h0a2.18,2.18,0,0,0-2.29-2.17l-11.68.63a1.54,1.54,0,0,0-1.45,1.54h0a1.54,1.54,0,0,0,1.45,1.54l11.68.63A2.17,2.17,0,0,0,74.91,56.31Z"
                },
                Style = new ShapeStyle()
                {
                    Fill = "#fff",
                    StrokeWidth = 0
                },
                Width = 15.420013427734375,
                Height = 4.346099853515625,
                OffsetX = 67.20000457763672,
                OffsetY = 56.310272216796875,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1209);
            Node FloorPlaneShapes1210 = new Node()
            {
                ID = "WashBasin_Mirror125Y2eYg",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M133.54,47.64h18.55a0,0,0,0,1,0,0V49.7a1,1,0,0,1-1,1H134.54a1,1,0,0,1-1-1V47.64A0,0,0,0,1,133.54,47.64Z"
                },
                Style = new ShapeStyle()
                {
                    Fill = "#fff",
                    StrokeWidth = 0
                },
                Width = 18.550003051757812,
                Height = 3.0600013732910156,
                OffsetX = 142.81499481201172,
                OffsetY = 49.170000076293945,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1210);
            Node FloorPlaneShapes1211 = new Node()
            {
                ID = "WashBasin_Mirror13dEOJiO",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M10.2,47.64H28.75a0,0,0,0,1,0,0V49.7a1,1,0,0,1-1,1H11.2a1,1,0,0,1-1-1V47.64A0,0,0,0,1,10.2,47.64Z"
                },
                Style = new ShapeStyle()
                {
                    Fill = "#fff",
                    StrokeWidth = 0
                },
                Width = 18.549999237060547,
                Height = 3.0600013732910156,
                OffsetX = 19.47499942779541,
                OffsetY = 49.170000076293945,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1211);
            Node FloorPlaneShapes1212 = new Node()
            {
                ID = "WashBasin_Mirror14YGyxGd",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M143.82,91.65a1,1,0,0,1-1-1V82.12a1,1,0,0,1,1-1h5.45a1,1,0,0,1,1,1Z"
                },
                Style = new ShapeStyle()
                {
                    Fill = "#fff",
                    StrokeWidth = 0
                },
                Width = 7.4499969482421875,
                Height = 10.529998779296875,
                OffsetX = 146.54500579833984,
                OffsetY = 86.38500213623047,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1212);
            NodeGroup FloorPlaneShapes1213 = new NodeGroup()
            {
                ID = "WashBasin_Mirror",
                Children = new string[] {
               "WashBasin_Mirror2siLuxk",
               "WashBasin_Mirror3Q9PxVP",
               "WashBasin_Mirror4a4GtBc",
               "WashBasin_Mirror5Ec581y",
               "WashBasin_Mirror6xYjsZx",
               "WashBasin_Mirror7H0IdfR",
               "WashBasin_Mirror8JGH6zw",
               "WashBasin_Mirror9K7WbYf",
               "WashBasin_Mirror10UE5NjR",
               "WashBasin_Mirror116kqZx9",
               "WashBasin_Mirror125Y2eYg",
               "WashBasin_Mirror13dEOJiO",
               "WashBasin_Mirror14YGyxGd"
            }
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1213);
            Node FloorPlaneShapes1194 = new Node()
            {
                ID = "Washbasin22mwWtpz",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M42,118.5V44.6A5.6,5.6,0,0,1,47.6,39h75.53a5.58,5.58,0,0,1,5.6,5.73c-.42,19-7.58,78.46-81,79.37A5.61,5.61,0,0,1,42,118.5Z"
                },
                Style = new ShapeStyle()
                {
                    Fill = "#dbdcdd",
                    StrokeWidth = 0
                },
                Width = 86.73202514648438,
                Height = 85.10133361816406,
                OffsetX = 85.36600875854492,
                OffsetY = 81.55062103271484,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1194);
            Node FloorPlaneShapes1195 = new Node()
            {
                ID = "Washbasin23RiEEC4",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M48,109.94V49.57A4.58,4.58,0,0,1,52.57,45h61.7a4.57,4.57,0,0,1,4.57,4.68c-.34,15.48-6.19,64.13-66.26,64.83A4.55,4.55,0,0,1,48,109.94Z"
                },
                Style = new ShapeStyle()
                {
                    Fill = "#7f7f7f",
                    StrokeWidth = 0
                },
                Width = 70.84136962890625,
                Height = 69.51010131835938,
                OffsetX = 83.4206428527832,
                OffsetY = 79.75504684448242,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1195);
            Node FloorPlaneShapes1196 = new Node()
            {
                ID = "Washbasin24R1ibaH",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M48,103V50a5,5,0,0,1,5-5h52S105,89.12,48,103Z"
                },
                Style = new ShapeStyle()
                {
                    Fill = "#fff",
                    StrokeWidth = 0
                },
                Width = 57,
                Height = 58,
                OffsetX = 76.5,
                OffsetY = 74,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1196);
            Node FloorPlaneShapes1197 = new Node()
            {
                ID = "Washbasin258VaJeD",
                Shape = new BasicShape()
                {
                    Type = Shapes.Basic,
                    Shape = BasicShapeType.Ellipse
                },
                Style = new ShapeStyle()
                {
                    Fill = "#fff"
                },
                Width = 7,
                Height = 7,
                OffsetX = 65,
                OffsetY = 61,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1197);
            Node FloorPlaneShapes1198 = new Node()
            {
                ID = "Washbasin26XjKRF6",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M84.34,41.29h0a2.31,2.31,0,0,1,2.3,2.43L86,56.07a1.63,1.63,0,0,1-1.63,1.54h0a1.62,1.62,0,0,1-1.62-1.54l-.67-12.35A2.3,2.3,0,0,1,84.34,41.29Z"
                },
                Style = new ShapeStyle()
                {
                    Fill = "#fff",
                    StrokeWidth = 0
                },
                Width = 4.5668182373046875,
                Height = 16.320003509521484,
                OffsetX = 84.3597183227539,
                OffsetY = 49.450002670288086,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1198);
            NodeGroup FloorPlaneShapes1199 = new NodeGroup()
            {
                ID = "Washbasin2",
                Children = new string[] {
               "Washbasin22mwWtpz",
               "Washbasin23RiEEC4",
               "Washbasin24R1ibaH",
               "Washbasin258VaJeD",
               "Washbasin26XjKRF6"
            }
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1199);
            Node FloorPlaneShapes1188 = new Node()
            {
                ID = "Washbasin12HCS1Cb",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M84.13,112.33h0A50.88,50.88,0,0,1,33.32,64.12,12.87,12.87,0,0,1,34,59.2V51a3.29,3.29,0,0,1,3.29-3.29h92.9a4,4,0,0,1,4,4V59.2a13.06,13.06,0,0,1,.71,4.92A50.89,50.89,0,0,1,84.13,112.33Z"
                },
                Style = new ShapeStyle()
                {
                    Fill = "#dbdcdd",
                    StrokeWidth = 0
                },
                Width = 101.6159439086914,
                Height = 64.62001037597656,
                OffsetX = 84.1071891784668,
                OffsetY = 80.02000427246094,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1188);
            Node FloorPlaneShapes1189 = new Node()
            {
                ID = "Washbasin13fWI7lW",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M84.13,106.33h0C62.9,106.33,45.4,93,43,75.87a13.27,13.27,0,0,1,.91-7l.8-1.91c1.14-2.72,4.23-4.55,7.69-4.55h63.51c3.46,0,6.55,1.83,7.69,4.55l.79,1.91a13.18,13.18,0,0,1,.92,7C122.86,93,105.36,106.33,84.13,106.33Z"
                },
                Style = new ShapeStyle()
                {
                    Fill = "#7f7f7f",
                    StrokeWidth = 0
                },
                Width = 82.56951904296875,
                Height = 43.92000198364258,
                OffsetX = 84.15504455566406,
                OffsetY = 84.3700008392334,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1189);
            Node FloorPlaneShapes1190 = new Node()
            {
                ID = "Washbasin14bwxPiq",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M55,96.21s28.25-41,58,0C113,96.21,85.16,118.24,55,96.21Z"
                },
                Style = new ShapeStyle()
                {
                    Fill = "#fff",
                    StrokeWidth = 0
                },
                Width = 58,
                Height = 28.013328552246094,
                OffsetX = 84,
                OffsetY = 91.99444961547852,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1190);
            Node FloorPlaneShapes1191 = new Node()
            {
                ID = "Washbasin156XUxTC",
                Shape = new BasicShape()
                {
                    Type = Shapes.Basic,
                    Shape = BasicShapeType.Ellipse
                },
                Style = new ShapeStyle()
                {
                    Fill = "#fff"
                },
                Width = 9,
                Height = 9,
                OffsetX = 84.5,
                OffsetY = 84.5,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1191);
            Node FloorPlaneShapes1192 = new Node()
            {
                ID = "Washbasin16SjrokS",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M83.38,50.32h0a3.7,3.7,0,0,1,3.7,3.9L86,74.12a2.62,2.62,0,0,1-2.62,2.48h0a2.63,2.63,0,0,1-2.62-2.48l-1.07-19.9A3.69,3.69,0,0,1,83.38,50.32Z"
                },
                Style = new ShapeStyle()
                {
                    Fill = "#fff",
                    StrokeWidth = 0
                },
                Width = 7.401397705078125,
                Height = 26.280014038085938,
                OffsetX = 83.38471221923828,
                OffsetY = 63.459999084472656,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1192);
            NodeGroup FloorPlaneShapes1193 = new NodeGroup()
            {
                ID = "Washbasin1",
                Children = new string[] {
               "Washbasin12HCS1Cb",
               "Washbasin13fWI7lW",
               "Washbasin14bwxPiq",
               "Washbasin156XUxTC",
               "Washbasin16SjrokS"
            }
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1193);
            Node FloorPlaneShapes1183 = new Node()
            {
                ID = "Washbasin2xLatbz",
                Shape = new BasicShape()
                {
                    Type = Shapes.Basic,
                    Shape = BasicShapeType.Rectangle,
                    CornerRadius = 43.5
                },
                Style = new ShapeStyle()
                {
                    Fill = "#707070"
                },
                Width = 87,
                Height = 87,
                OffsetX = 82.5,
                OffsetY = 80.5,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1183);
            Node FloorPlaneShapes1184 = new Node()
            {
                ID = "Washbasin30qnQfG",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M84,50H81A34,34,0,0,0,47,84h0a34,34,0,0,0,34,34h3a34,34,0,0,0,34-34h0A34,34,0,0,0,84,50ZM82,86a6,6,0,1,1,6-6A6,6,0,0,1,82,86Z"
                },
                Style = new ShapeStyle()
                {
                    Fill = "#d1d2d3",
                    StrokeWidth = 0
                },
                Width = 71,
                Height = 68,
                OffsetX = 82.5,
                OffsetY = 84,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1184);
            Node FloorPlaneShapes1185 = new Node()
            {
                ID = "Washbasin4cmVZFl",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M57.21,107.79a33.77,33.77,0,0,1,0-47.75h0C70.45,46.85,93.83,45.83,107,59Z"
                },
                Style = new ShapeStyle()
                {
                    Fill = "#fff",
                    StrokeWidth = 0
                },
                Width = 59.677005767822266,
                Height = 58.17007827758789,
                OffsetX = 77.16149711608887,
                OffsetY = 78.7049617767334,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1185);
            Node FloorPlaneShapes1186 = new Node()
            {
                ID = "Washbasin5WpMfbs",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M82.3,38.32h0A3.69,3.69,0,0,1,86,42.22l-1.07,19.9A2.63,2.63,0,0,1,82.3,64.6h0a2.62,2.62,0,0,1-2.62-2.48L78.6,42.22A3.71,3.71,0,0,1,82.3,38.32Z"
                },
                Style = new ShapeStyle()
                {
                    Fill = "#fff",
                    StrokeWidth = 0
                },
                Width = 7.410850524902344,
                Height = 26.280040740966797,
                OffsetX = 82.30055618286133,
                OffsetY = 51.45998573303223,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1186);
            NodeGroup FloorPlaneShapes1187 = new NodeGroup()
            {
                ID = "Washbasin",
                Children = new string[] {
               "Washbasin2xLatbz",
               "Washbasin30qnQfG",
               "Washbasin4cmVZFl",
               "Washbasin5WpMfbs"
            }
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1187);
            Node FloorPlaneShapes1175 = new Node()
            {
                ID = "VerticalWall2DppOoX",
                Shape = new BasicShape()
                {
                    Type = Shapes.Basic,
                    Shape = BasicShapeType.Rectangle
                },
                Style = new ShapeStyle()
                {
                    Fill = "#464747"
                },
                Width = 113,
                Height = 14,
                OffsetX = 81,
                OffsetY = 80.5,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1175);
            NodeGroup FloorPlaneShapes1176 = new NodeGroup()
            {
                ID = "Vertical Wall",
                Children = new string[] {
               "VerticalWall2DppOoX"
            }
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1176);
            Node FloorPlaneShapes1177 = new Node()
            {
                ID = "Wardrobe2DkdyWy",
                Shape = new BasicShape()
                {
                    Type = Shapes.Basic,
                    Shape = BasicShapeType.Rectangle
                },
                Style = new ShapeStyle()
                {
                    Fill = "url(#linear-gradient)"
                },
                Width = 77,
                Height = 4,
                OffsetX = 38.5,
                OffsetY = 100,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1177);
            Node FloorPlaneShapes1178 = new Node()
            {
                ID = "Wardrobe3I9qfIw",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M160 101.29 83.92 111.29 82.92 107.54 160 97.54 160 101.29"
                },
                Style = new ShapeStyle()
                {
                    Fill = "url(#linear-gradient-2)"
                },
                Width = 77.08000183105469,
                Height = 13.75,
                OffsetX = 121.45999908447266,
                OffsetY = 104.41500091552734,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1178);
            Node FloorPlaneShapes1179 = new Node()
            {
                ID = "Wardrobe41tIQyC",
                Shape = new PathShape()
                {
                    Type = Shapes.Path,
                    Data = "M4,54H156a4,4,0,0,1,4,4V98a0,0,0,0,1,0,0H0a0,0,0,0,1,0,0V58A4,4,0,0,1,4,54Z"
                },
                Style = new ShapeStyle()
                {
                    Fill = "#522c0a",
                    StrokeWidth = 0
                },
                Width = 160,
                Height = 44,
                OffsetX = 80,
                OffsetY = 76,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1179);
            Node FloorPlaneShapes1180 = new Node()
            {
                ID = "Wardrobe5Kkgznd",
                Shape = new BasicShape()
                {
                    Type = Shapes.Basic,
                    Shape = BasicShapeType.Rectangle,
                    CornerRadius = 0.5
                },
                Style = new ShapeStyle()
                {
                    Fill = "#522c0a"
                },
                Width = 3,
                Height = 1,
                OffsetX = 49.5,
                OffsetY = 102.5,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1180);
            Node FloorPlaneShapes1181 = new Node()
            {
                ID = "Wardrobe6o9EXmW",
                Shape = new BasicShape()
                {
                    Type = Shapes.Basic,
                    Shape = BasicShapeType.Rectangle,
                    CornerRadius = 0.5
                },
                Style = new ShapeStyle()
                {
                    Fill = "#522c0a"
                },
                Width = 3,
                Height = 1,
                OffsetX = 115.17000579833984,
                OffsetY = 107.69000244140625,
                Constraints = NodeConstraints.Default & ~NodeConstraints.Select
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1181);
            NodeGroup FloorPlaneShapes1182 = new NodeGroup()
            {
                ID = "Wardrobe",
                Children = new string[] {
               "Wardrobe2DkdyWy",
               "Wardrobe3I9qfIw",
               "Wardrobe41tIQyC",
               "Wardrobe5Kkgznd",
               "Wardrobe6o9EXmW"
            }
            };
            FloorPlaneShapesList.Add(FloorPlaneShapes1182);

            FloorPlaneShapes = new Palette() { ID = "FloorPlaneShapes", IsExpanded = false, Symbols = FloorPlaneShapesList, Title = "Floor Plane Shapes" };

        }

        internal async Task UpdatePalettes(List<DiagramMoreShapes.ListViewDataFields> SelectedItems)
        {
            DiagramObjectCollection<Palette> AddPalettes = new DiagramObjectCollection<Palette>();
            List<string> RemovePalette = new List<string>();
            foreach (DiagramMoreShapes.ListViewDataFields data in SelectedItems)
            {
                string paletteName = data.Text; bool isChecked = data.Checked;
                switch (paletteName)
                {
                    case "Flow":
                        if (isChecked)
                        {
                            if (!Palettes.Contains(FlowShapePalette))
                            AddPalettes.Add(FlowShapePalette);
                            PaletteInstance.AddPalettes(AddPalettes);   
                        }
                        else
                            PaletteInstance.RemovePalettes(FlowShapePalette.ID);
                        break;
                    case "Basic":
                        if (isChecked)
                        {
                            if (!Palettes.Contains(BasicShapePalette))
                            AddPalettes.Add(BasicShapePalette);
                            PaletteInstance.AddPalettes(AddPalettes);
                        }
                        else
                            PaletteInstance.RemovePalettes(BasicShapePalette.ID);
                        break;
                    //case "BPMN":
                    //    if (isChecked)
                    //    {
                    //        if (!Palettes.Contains(BpmnShapePalette))
                    //            AddPalettes.Add(BpmnShapePalette);
                    //        //PaletteInstance.AddPalettes(AddPalettes);
                    //    }
                    //    else
                    //        //RemovePalette.Add(BpmnShapePalette.Id);
                    //        PaletteInstance.RemovePalettes(BpmnShapePalette.ID);
                    //    break;
                    case "Connectors":
                        if (isChecked)
                        {
                            if (!Palettes.Contains(ConnectorPalette))
                                AddPalettes.Add(ConnectorPalette);
                                PaletteInstance.AddPalettes(AddPalettes);
                        }
                        else
                            PaletteInstance.RemovePalettes(ConnectorPalette.ID);
                        break;
                    case "HTML":
                        if (isChecked)
                        {
                            if (!Palettes.Contains(HtmlShapePalette))
                            AddPalettes.Add(HtmlShapePalette);
                            PaletteInstance.AddPalettes(AddPalettes);
                        }
                        else
                            PaletteInstance.RemovePalettes(HtmlShapePalette.ID);
                        break;
                    case "Native":
                        if (isChecked)
                        {
                            if (!Palettes.Contains(NativeShapePalette))
                            AddPalettes.Add(NativeShapePalette);
                            PaletteInstance.AddPalettes(AddPalettes);
                        }
                        else
                            PaletteInstance.RemovePalettes(NativeShapePalette.ID);
                        break;
                    //    case "Electrical":
                    //        if (isChecked)
                    //        {
                    //            if (!Palettes.Contains(ElectericalAudio))
                    //                AddPalettes.Add(ElectericalAudio);
                    //            if (!Palettes.Contains(ElectricalCapacitors))
                    //                AddPalettes.Add(ElectricalCapacitors);
                    //            if (!Palettes.Contains(ElectricalDiodes))
                    //                AddPalettes.Add(ElectricalDiodes);
                    //            if (!Palettes.Contains(ElectricalGates))
                    //                AddPalettes.Add(ElectricalGates);
                    //            if (!Palettes.Contains(ElectricalInductors))
                    //                AddPalettes.Add(ElectricalInductors);
                    //            if (!Palettes.Contains(ElectricalInstruments))
                    //                AddPalettes.Add(ElectricalInstruments);
                    //            if (!Palettes.Contains(ElectricalMics))
                    //                AddPalettes.Add(ElectricalMics);
                    //            if (!Palettes.Contains(ElectricalOptical))
                    //                AddPalettes.Add(ElectricalOptical);
                    //            if (!Palettes.Contains(ElectricalPLCLadder))
                    //                AddPalettes.Add(ElectricalPLCLadder);
                    //            if (!Palettes.Contains(ElectricalResistor))
                    //                AddPalettes.Add(ElectricalResistor);
                    //            if (!Palettes.Contains(ElectricalRotatingEquipment))
                    //                AddPalettes.Add(ElectricalRotatingEquipment);
                    //            if (!Palettes.Contains(ElectricalSources))
                    //                AddPalettes.Add(ElectricalSources);
                    //            if (!Palettes.Contains(ElectricalTransmission))
                    //                AddPalettes.Add(ElectricalTransmission);
                    //            if (!Palettes.Contains(ElectricalSwitches))
                    //                AddPalettes.Add(ElectricalSwitches);
                    //            if (!Palettes.Contains(ElectricalTransistors))
                    //                AddPalettes.Add(ElectricalTransistors);
                    //            if (!Palettes.Contains(ElectricalVaccumTubes))
                    //                AddPalettes.Add(ElectricalVaccumTubes);
                    //            if (!Palettes.Contains(ElectricalWaveFormsEquipment))
                    //                AddPalettes.Add(ElectricalWaveFormsEquipment);
                    //        }
                    //        else
                    //        {
                    //            RemovePalettes.Add(ElectericalAudio.Id);
                    //            RemovePalettes.Add(ElectricalCapacitors.Id);
                    //            RemovePalettes.Add(ElectricalDiodes.Id);
                    //            RemovePalettes.Add(ElectricalGates.Id);
                    //            RemovePalettes.Add(ElectricalInductors.Id);
                    //            RemovePalettes.Add(ElectricalInstruments.Id);
                    //            RemovePalettes.Add(ElectricalMics.Id);
                    //            RemovePalettes.Add(ElectricalOptical.Id);
                    //            RemovePalettes.Add(ElectricalPLCLadder.Id);
                    //            RemovePalettes.Add(ElectricalResistor.Id);
                    //            RemovePalettes.Add(ElectricalRotatingEquipment.Id);
                    //            RemovePalettes.Add(ElectricalSources.Id);
                    //            RemovePalettes.Add(ElectricalTransmission.Id);
                    //            RemovePalettes.Add(ElectricalSwitches.Id);
                    //            RemovePalettes.Add(ElectricalTransistors.Id);
                    //            RemovePalettes.Add(ElectricalVaccumTubes.Id);
                    //            RemovePalettes.Add(ElectricalWaveFormsEquipment.Id);
                    //        }
                    //        break;
                    case "Network":
                        if (isChecked)
                        {
                            if (!Palettes.Contains(NetworkShapes))
                                AddPalettes.Add(NetworkShapes);
                            //PaletteInstance.AddPalettes(AddPalettes);

                        }
                        else
                            PaletteInstance.RemovePalettes(NetworkShapes.ID);
                        break;
                    case "Floorplan":
                        if (isChecked)
                        {
                            if (!Palettes.Contains(FloorPlaneShapes))
                                AddPalettes.Add(FloorPlaneShapes);
                            //PaletteInstance.AddPalettes(AddPalettes);
                        }
                        else
                            PaletteInstance.RemovePalettes(FloorPlaneShapes.ID);
                        break;
                }
            }
            PaletteInstance.AddPalettes(AddPalettes);
            //await PaletteInstance.RemovePalettes(RemovePalette.ToArray());
            StateHasChanged();
        }
    }
}
