using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;

public class Guess : MonoBehaviour
{
    string guess = "xxx";

    [SerializeField]
    private Player playerObj;
    [SerializeField]
    private GameObject explosionPrefab;
    [SerializeField]
    private GameObject explosionSFPrefab;

    private PlayerInput playerInput;

    private void Awake()
    {
        playerInput = playerObj.GetComponent<PlayerInput>();
    }

    private void OnEnable()
    {
        playerInput.actions["A"].performed += A_performed;
        playerInput.actions["I"].performed += I_performed;
        playerInput.actions["U"].performed += U_performed;
        playerInput.actions["E"].performed += E_performed;
        playerInput.actions["O"].performed += O_performed;
        playerInput.actions["K"].performed += K_performed;
        playerInput.actions["S"].performed += S_performed;
        playerInput.actions["T"].performed += T_performed;
        playerInput.actions["N"].performed += N_performed;
        playerInput.actions["H"].performed += H_performed;
        playerInput.actions["M"].performed += M_performed;
        playerInput.actions["Y"].performed += Y_performed;
        playerInput.actions["R"].performed += R_performed;
        playerInput.actions["W"].performed += W_performed;
        playerInput.actions["C"].performed += C_performed;
        playerInput.actions["G"].performed += G_performed;
        playerInput.actions["Z"].performed += Z_performed;
        playerInput.actions["D"].performed += D_performed;
        playerInput.actions["B"].performed += B_performed;
        playerInput.actions["P"].performed += P_performed;
        playerInput.actions["J"].performed += J_performed;
        playerInput.actions["F"].performed += F_performed;
    }

    private void OnDisable()
    {
        playerInput.actions["A"].performed -= A_performed;
        playerInput.actions["I"].performed -= I_performed;
        playerInput.actions["U"].performed -= U_performed;
        playerInput.actions["E"].performed -= E_performed;
        playerInput.actions["O"].performed -= O_performed;
        playerInput.actions["K"].performed -= K_performed;
        playerInput.actions["S"].performed -= S_performed;
        playerInput.actions["T"].performed -= T_performed;
        playerInput.actions["N"].performed -= N_performed;
        playerInput.actions["H"].performed -= H_performed;
        playerInput.actions["M"].performed -= M_performed;
        playerInput.actions["Y"].performed -= Y_performed;
        playerInput.actions["R"].performed -= R_performed;
        playerInput.actions["W"].performed -= W_performed;
        playerInput.actions["C"].performed -= C_performed;
        playerInput.actions["G"].performed -= G_performed;
        playerInput.actions["Z"].performed -= Z_performed;
        playerInput.actions["D"].performed -= D_performed;
        playerInput.actions["B"].performed -= B_performed;
        playerInput.actions["P"].performed -= P_performed;
        playerInput.actions["J"].performed -= J_performed;
        playerInput.actions["F"].performed -= F_performed;
    }


    void makeGuess(string input)
    {
            string newGuess = guess.Substring(Mathf.Max(0, guess.Length - 2));

            newGuess = newGuess + input;

            string Guess_3 = newGuess;
            string Guess_2 = newGuess.Substring(Mathf.Max(0, guess.Length - 2));
            string Guess_1 = newGuess.Substring(Mathf.Max(0, guess.Length - 1));

            GameObject[] syllables;
            syllables = GameObject.FindGameObjectsWithTag("Syllable");


            foreach (GameObject syllable in syllables)
            {
                if (syllable.GetComponent<Syllable>().Romaji.ToLower() == Guess_3.ToLower())
                {
                    playerObj.Score += 1;
                    playerObj.Concentration += 2;
                    Instantiate(explosionPrefab, syllable.transform.position, Quaternion.identity);
                    Instantiate(explosionSFPrefab, syllable.transform.position, Quaternion.identity);
                    Destroy(syllable);
                    guess = newGuess;
                    return;
                }
            }

            foreach (GameObject syllable in syllables)
            {
                if (syllable.GetComponent<Syllable>().Romaji.ToLower() == Guess_2.ToLower())
                {
                    playerObj.Score += 1;
                    playerObj.Concentration += 1;
                    Instantiate(explosionPrefab, syllable.transform.position, Quaternion.identity);
                    Instantiate(explosionSFPrefab, syllable.transform.position, Quaternion.identity);
                    Destroy(syllable);
                    guess = newGuess;
                    return;
                }
            }

            foreach (GameObject syllable in syllables)
            {
                if (syllable.GetComponent<Syllable>().Romaji.ToLower() == Guess_1.ToLower())
                {
                    playerObj.Score += 1;
                    Instantiate(explosionPrefab, syllable.transform.position, Quaternion.identity);
                    Instantiate(explosionSFPrefab, syllable.transform.position, Quaternion.identity);
                    Destroy(syllable);
                    guess = newGuess;
                    return;
                }
            }
            guess = newGuess;
            playerObj.Concentration = playerObj.Concentration - 1;

    }

    private void A_performed(InputAction.CallbackContext context)
    {
        makeGuess("a");
    }
    private void I_performed(InputAction.CallbackContext context)
    {
        makeGuess("i");
    }
    private void U_performed(InputAction.CallbackContext context)
    {
        makeGuess("u");
    }
    private void E_performed(InputAction.CallbackContext context)
    {
        makeGuess("e");
    }
    private void O_performed(InputAction.CallbackContext context)
    {
        makeGuess("o");
    }
    private void K_performed(InputAction.CallbackContext context)
    {
        makeGuess("k");
    }
    private void S_performed(InputAction.CallbackContext context)
    {
        makeGuess("s");
    }
    private void T_performed(InputAction.CallbackContext context)
    {
        makeGuess("t");
    }
    private void N_performed(InputAction.CallbackContext context)
    {
        makeGuess("n");
    }
    private void H_performed(InputAction.CallbackContext context)
    {
        makeGuess("h");
    }
    private void M_performed(InputAction.CallbackContext context)
    {
        makeGuess("m");
    }
    private void Y_performed(InputAction.CallbackContext context)
    {
        makeGuess("y");
    }
    private void R_performed(InputAction.CallbackContext context)
    {
        makeGuess("r");
    }
    private void W_performed(InputAction.CallbackContext context)
    {
        makeGuess("w");
    }
    private void C_performed(InputAction.CallbackContext context)
    {
        makeGuess("c");
    }
    private void G_performed(InputAction.CallbackContext context)
    {
        makeGuess("g");
    }
    private void Z_performed(InputAction.CallbackContext context)
    {
        makeGuess("z");
    }
    private void D_performed(InputAction.CallbackContext context)
    {
        makeGuess("d");
    }
    private void B_performed(InputAction.CallbackContext context)
    {
        makeGuess("b");
    }
    private void P_performed(InputAction.CallbackContext context)
    {
        makeGuess("p");
    }
    private void J_performed(InputAction.CallbackContext context)
    {
        makeGuess("j");
    }
    private void F_performed(InputAction.CallbackContext context)
    {
        makeGuess("f");
    }











}
