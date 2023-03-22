using NodeFile;

namespace RouteFile
{
    class Route
    {
        // === ATTRIBUTES ======================================================================
        private Node?[] routeGraph;
        private string?[] routeSteps;
        private int nSteps;

        // === CONSTRUCTOR =====================================================================
        public Route()
        {
            this.routeGraph = new Node[100];
            this.routeSteps = new string[100];
            this.nSteps = 0;
        }

        // === GETTER SETTER ===================================================================
        public Node? getNodeRoute(int idx)
        {
            return routeGraph[idx];
        }

        public string? getStepRoute(int idx)
        {
            return routeSteps[idx];
        }

        public int getNSteps()
        {
            return this.nSteps;
        }

        // === METHODS =========================================================================
        public void addNodeToRoute(Node newNode)
        {
            for (int i = 0; i < 100; i++)
            {
                if (routeGraph[i] == null)
                {
                    routeGraph[i] = newNode;
                    break;
                }
            }
        }

        public void removeNodeFromRoute()
        {
            for (int i = 0; i < 100; i++)
            {
                if (routeGraph[i] == null)
                {
                    routeGraph[i - 1] = null;
                    break;
                }
            }
        }

        public void addStepToRoute(string newStep)
        {
            for (int i = 0; i < 100; i++)
            {
                if (routeSteps[i] == null)
                {
                    routeSteps[i] = newStep;
                    break;
                }
            }
            this.nSteps++;
        }

        public void removeStepFromRoute()
        {
            for (int i = 0; i < 100; i++)
            {
                if (routeSteps[i] == null)
                {
                    routeSteps[i - 1] = null;
                    break;
                }
            }
            this.nSteps--;
        }

        public void initializeStep()
        {
            for (int i = 1; i < 100; i++)
            {
                if (this.routeGraph[i] == null)
                {
                    break;
                }

                if (this.routeGraph[i - 1].getPosY() - 1 == this.routeGraph[i].getPosY())
                {
                    addStepToRoute("L");
                }
                if (this.routeGraph[i - 1].getPosX() - 1 == this.routeGraph[i].getPosX())
                {
                    addStepToRoute("U");
                }
                if (this.routeGraph[i - 1].getPosY() + 1 == this.routeGraph[i].getPosY())
                {
                    addStepToRoute("R");
                }
                if (this.routeGraph[i - 1].getPosX() + 1 == this.routeGraph[i].getPosX())
                {
                    addStepToRoute("D");
                }
            }
        }
    }
}