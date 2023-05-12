namespace Banker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRunBankersAlgorithm_Click(object sender, EventArgs e)
        {
            int numProcesses = gvMaxNeed.Rows.Count;
            int numResources = gvMaxNeed.Columns.Count;
            int[,] maxNeed = new int[numProcesses, numResources];
            int[,] currentAllocation = new int[numProcesses, numResources];
            int[] totalResources = new int[numResources];
            int[] availableResources = new int[numResources];

            // Read input values from grid views
            for (int i = 0; i < numProcesses; i++)
            {
                for (int j = 0; j < numResources; j++)
                {
                    maxNeed[i, j] = Convert.ToInt32(gvMaxNeed.Rows[i].Cells[j].Value);
                    currentAllocation[i, j] = Convert.ToInt32(gvCurrentAllocation.Rows[i].Cells[j].Value);
                }
            }

            for (int j = 0; j < numResources; j++)
            {
                totalResources[j] = Convert.ToInt32(gvTotalResources.Rows[0].Cells[j].Value);
                availableResources[j] = Convert.ToInt32(gvAvailableResources.Rows[0].Cells[0].Value);
            }

            // Run banker's algorithm
            int[] work = (int[])availableResources.Clone();
            bool[] finish = new bool[numProcesses];
            List<int> safeSequence = new List<int>();

            while (safeSequence.Count < numProcesses)
            {
                bool foundProcess = false;

                for (int i = 0; i < numProcesses; i++)
                {
                    if (!finish[i])
                    {
                        bool canExecute = true;

                        for (int j = 0; j < numResources; j++)
                        {
                            if (maxNeed[i, j] - currentAllocation[i, j] > work[j])
                            {
                                canExecute = false;
                                break;
                            }
                        }

                        if (canExecute)
                        {
                            for (int j = 0; j < numResources; j++)
                            {
                                work[j] += currentAllocation[i, j];
                            }

                            finish[i] = true;
                            safeSequence.Add(i);
                            foundProcess = true;
                            break;
                        }
                    }
                }

                if (!foundProcess)
                {
                    break;
                }
            }

            if (safeSequence.Count == numProcesses)
            {
                MessageBox.Show("System is in a safe state.\nSafe sequence: " + string.Join(",", safeSequence.Select(i => "P" + i)));
            }
            else
            {
                MessageBox.Show("System is not in a safe state.");
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRequestResource_Click(object sender, EventArgs e)
        {
            int processIndex = Convert.ToInt32(txtProcessIndex.Text);
            int resourceIndex = Convert.ToInt32(txtResourceIndex.Text);
            int requestAmount = Convert.ToInt32(txtRequestAmount.Text);

            // Get the current state of the system
            int numProcesses = gvMaxNeed.Rows.Count;
            int numResources = gvMaxNeed.Columns.Count;
            int[,] maxNeed = new int[numProcesses, numResources];
            int[,] currentAllocation = new int[numProcesses, numResources];
            int[,] need = new int[numProcesses, numResources];
            int[] totalResources = new int[numResources];
            int[] availableResources = new int[numResources];

            for (int i = 0; i < numProcesses; i++)
            {
                for (int j = 0; j < numResources; j++)
                {
                    maxNeed[i, j] = Convert.ToInt32(gvMaxNeed.Rows[i].Cells[j].Value);
                    currentAllocation[i, j] = Convert.ToInt32(gvCurrentAllocation.Rows[i].Cells[j].Value);
                    need[i, j] = maxNeed[i, j] - currentAllocation[i, j];
                }
            }

            for (int j = 0; j < numResources; j++)
            {
                totalResources[j] = Convert.ToInt32(gvTotalResources.Rows[0].Cells[j].Value);
                availableResources[j] = Convert.ToInt32(gvAvailableResources.Rows[0].Cells[j].Value);
            }

            // Check if the request is valid
            if (requestAmount <= need[processIndex, resourceIndex] && requestAmount <= availableResources[resourceIndex])
            {
                // Simulate the allocation of resources to the process
                availableResources[resourceIndex] -= requestAmount;
                currentAllocation[processIndex, resourceIndex] += requestAmount;
                need[processIndex, resourceIndex] -= requestAmount;

                // Check if the new state is safe
                int[] work = (int[])availableResources.Clone();
                bool[] finish = new bool[numProcesses];
                List<int> safeSequence = new List<int>();

                while (safeSequence.Count < numProcesses)
                {
                    bool foundProcess = false;

                    for (int i = 0; i < numProcesses; i++)
                    {
                        if (!finish[i])
                        {
                            bool canExecute = true;

                            for (int j = 0; j < numResources; j++)
                            {
                                if (need[i, j] > work[j])
                                {
                                    canExecute = false;
                                    break;
                                }
                            }

                            if (canExecute)
                            {
                                for (int j = 0; j < numResources; j++)
                                {
                                    work[j] += currentAllocation[i, j];
                                }

                                finish[i] = true;
                                safeSequence.Add(i);
                                foundProcess = true;
                                break;
                            }
                        }
                    }

                    if (!foundProcess)
                    {
                        break;
                    }
                }

                // Revert the allocation if the new state is not safe
                if (safeSequence.Count != numProcesses)
                {
                    availableResources[resourceIndex] += requestAmount;
                    currentAllocation[processIndex, resourceIndex] -= requestAmount;
                    need[processIndex, resourceIndex] += requestAmount;

                    MessageBox.Show("Request cannot be granted. System is not in a safe state.");
                }
                else
                {
                    MessageBox.Show("Request granted. System is in a safe state.\nSafe sequence: " +
                    string.Join(",", safeSequence.Select(x => x.ToString())));
                }

            }

        }

    }
}