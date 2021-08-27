using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Reference: https://www.youtube.com/watch?v=CGsEJToeXmA&ab_channel=GameDevGuide

namespace JTools.UI
{
    /// <summary>
    /// An alternative to the normal grid layout that may or may not be more useful than the default one...
    /// </summary>
    public class CustomGridLayout : LayoutGroup
    {
        /// <summary>
        /// The layout fitting type for the grid layout...
        /// </summary>
        public enum LayoutFitType
        {
            Default,
            Width,
            Height,
            FixedRows,
            FixedColumns,
        };

        /// <summary>
        /// The style of fitting needed... This is only used on the fixed types...
        /// </summary>
        public enum LayoutFitAxis
        {
            None,
            X,
            Y,
            Both,
        };
        
        public enum LayoutAlignment
        {
            Horizontal,
            Vertical
        }

        /// <summary>
        /// The fit type to use...
        /// </summary>
        public LayoutFitType fitType;
        
        /// <summary>
        /// The number of rows to have...
        /// </summary>
        public int rows;
        
        /// <summary>
        /// The number of columns to have...
        /// </summary>
        public int columns;
        
        /// <summary>
        /// The size of the each cell in the grid layout...
        /// </summary>
        public Vector2 cellSize;
        
        /// <summary>
        /// The amount of spacing between each cell in the layout...
        /// </summary>
        public Vector2 spacing;
        
        /// <summary>
        /// The fit style desired... 
        /// </summary>
        public LayoutFitAxis fitAxis;

        public LayoutAlignment alignment;


        
        public override void CalculateLayoutInputVertical()
        {
            // The Default stuff for this method...
            base.CalculateLayoutInputHorizontal();

            // Sets the row and column amounts based on the enum settings...
            GetChildrenRowColumns();
            
            // Sets the size vector based on the padding/spacing etc...
            var _size = GetCellSize(GetContainerSize());


            // Sets the cell size based on the axis...
            switch (fitAxis)
            {
                case LayoutFitAxis.None:
                    cellSize.x = _size[0];
                    cellSize.y = _size[1];
                    break;
                case LayoutFitAxis.X:
                    cellSize.x = _size[0];
                    break;
                case LayoutFitAxis.Y:
                    cellSize.y = _size[1];
                    break;
                case LayoutFitAxis.Both:
                    cellSize.x = _size[0];
                    cellSize.y = _size[1];
                    break;
            }

            // Applies the layout...
            SetLayout();
        }


        public override void SetLayoutHorizontal()
        {
        }

        public override void SetLayoutVertical()
        {
        }


        /// <summary>
        /// Gets the number of rows & columns based on the child count or by the row/column count set manually...
        /// </summary>
        private void GetChildrenRowColumns()
        {
            if (fitType.Equals(LayoutFitType.Default) || fitType.Equals(LayoutFitType.Width) ||
                fitType.Equals(LayoutFitType.Height))
            {
                fitAxis = LayoutFitAxis.None;
                var _sqr = Mathf.Sqrt(transform.childCount);
                rows = Mathf.CeilToInt(_sqr);
                columns = Mathf.CeilToInt(_sqr);
            }


            if (fitType.Equals(LayoutFitType.Default) || fitType.Equals(LayoutFitType.Width) ||
                fitType.Equals(LayoutFitType.FixedColumns))
            {
                rows = Mathf.CeilToInt(transform.childCount / (float) columns);
            }
            
            
            if (fitType.Equals(LayoutFitType.Default) || fitType.Equals(LayoutFitType.Height) ||
                fitType.Equals(LayoutFitType.FixedRows))
            {
                columns = Mathf.CeilToInt(transform.childCount / (float) rows);
            }
        }
        
        
        /// <summary>
        /// Gets the size of the rect to constrain to objects to...
        /// </summary>
        /// <returns>Float Array</returns>
        private float[] GetContainerSize()
        {
            var _rect = rectTransform.rect;
            return new float[2] {_rect.width, _rect.height};
        }


        /// <summary>
        /// Gets the size of each cell in the container....
        /// </summary>
        /// <param name="containerSize">The container size...</param>
        /// <returns>Float Array</returns>
        private float[] GetCellSize(IReadOnlyList<float> containerSize)
        {
            return new float[2]
            {
                containerSize[0] / (float) columns - (spacing.x / (float) columns) * (columns - 1) -
                (padding.left / (float) columns) - (padding.right / (float) columns),
                containerSize[1] / (float) rows - (spacing.y / (float) rows) * (rows - 1) - (padding.top / (float) rows) -
                (padding.bottom / (float) rows)
            };
        }


        /// <summary>
        /// Sets the layout with all the settings defined...
        /// </summary>
        private void SetLayout()
        {
            var columnCount = 0;
            var rowCount = 0;

            for (int i = 0; i < rectChildren.Count; i++)
            {
                var item = rectChildren[i];

                if (alignment == LayoutAlignment.Horizontal)
                {
                    rowCount = i / columns;
                    columnCount = i % columns;
                    var xPos = (cellSize.x * columnCount) + (spacing.x * columnCount) + padding.left;
                    var yPos = (cellSize.y * rowCount) + (spacing.y * rowCount) + padding.top;

                    SetChildAlongAxis(item, 0, xPos, cellSize.x);
                    SetChildAlongAxis(item, 1, yPos, cellSize.y);
                }
                else
                {
                    rowCount = i / rows;
                    columnCount = i % rows;
                    var xPos = (cellSize.x * columnCount) + (spacing.x * columnCount) + padding.left;
                    var yPos = (cellSize.y * rowCount) + (spacing.y * rowCount) + padding.top;

                    SetChildAlongAxis(item, 0, yPos, cellSize.y);
                    SetChildAlongAxis(item, 1, xPos, cellSize.x);
                }
            }
        }
    }
}