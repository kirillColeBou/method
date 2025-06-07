using prac.Classes.Context;

namespace method
{
    public class CalculateMaterial
    {
        public int GetCalculateMaterials(int typeProductName, int idMaterials, int countProduct, double parameter_1, double parameter_2)
        {
            Context context = new Context();
            try
            {
                double coefficient = context.typeProduct.FirstOrDefault(x => x.id == typeProductName).coefficient;
                double defectRate = context.material.FirstOrDefault(x => x.id == idMaterials).defectRate;
                double receivedOneProduct = parameter_1 * parameter_2 * coefficient;
                double receivedNotDefect = receivedOneProduct * countProduct;
                double result = receivedNotDefect + receivedNotDefect * defectRate;
                return (int)Math.Ceiling(result);
            }
            catch { return -1; }
        }
    }
}
