using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class cpf : MonoBehaviour
{
    [SerializeField] TMP_InputField cpfTxt;
    [SerializeField] TMP_Text validationTxt;

    int result;
    List<int> listCpf = new List<int>();
    private void Start()
    {
        validationTxt.text = "";
    }
    public void validation()
    {
        string cpf = cpfTxt.text;
        if (cpf.Length != 11)
        {
            validationTxt.text = "Write a real CPF";
        }

        listCpf.Clear();
        for (int i = 0; i < 9; i++)
        {
            listCpf.Add(int.Parse(cpf[i].ToString()));
        }

        if (listCpf.All(d => d == listCpf[0]))
        {
            validationTxt.text = "You can't write a sequence of the same numbers";

        }
        else
        {

            result = 0;
            for (int j = 0; j < 9; j++)
            {
                result += listCpf[j] * (10 - j);
            }

            int digito1 = (result * 10) % 11;
            if (digito1 == 10) digito1 = 0;

            listCpf.Add(digito1);

            result = 0;
            for (int j = 0; j < 10; j++)
            {
                result += listCpf[j] * (11 - j);
            }

            int digito2 = (result * 10) % 11;
            if (digito2 == 10) digito2 = 0;


            if (digito1 == ((cpf[9] - '0')) && digito2 == (cpf[10] - '0'))
            {
                validationTxt.text = "real CPF";
            }
            else
            {
                validationTxt.text = "CPF doesn't exist";
            }
        }
    }
}