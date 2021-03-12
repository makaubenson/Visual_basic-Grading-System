Public Class project

    Dim studentname As String = ""  'String to store the student name
    'Mark 1,2 and 3 are used to store the values the user inputs for first mark,Second mark and third Mark 
    'in the form
    Dim mark1 As String = ""
    Dim mark2 As String = ""
    Dim mark3 As String = ""

    'state is used to confirm if all the input fields have been entered,ie it is only initialized and given a value
    'after the input fields have been confirmed not to be empty, if state is not initialized the program does not
    'proceed to do the calculations as demonstrated in the code. 
    Dim state As String = ""

    'winnerone,winnertwo and winnerthree are used to store the value of the Max number returned by the Math class
    'when comparing size of the three biggest marks entered by the user
    Dim winnerone As Decimal
    Dim winnertwo As Decimal
    Dim winnerthree As Decimal

    'The five decimals below are used to compare the size of user marks ie biggest,smallest number by holding values
    'for biggest,middle and smalles numbers,see code for understanding 
    Dim middle As Decimal
    Dim firstwinner As Decimal
    Dim finallwinner As Decimal
    Dim middlewinner As Decimal
    Dim finallooser As Decimal

    'markinputone,markinputtwo,markinputthree are used to store the Interger value of the user's input fields
    'then used to confirm that the input given meets the  expected conditions is NOT <0 AND NOT > 100
    Dim markinputone As Integer
    Dim markinputtwo As Integer
    Dim markinputthree As Integer

    'numberone,numbertwo,numberthree store the Interger value stored in mark1,mark2,mark3 that get their values
    'from the user inputs.
    Dim numberone As Integer
    Dim numbertwo As Integer
    Dim numberthree As Integer


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub savedatabtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savedatabtn.Click


        If (username.Text <> "") Then    'checks if username is empty

            If (marka.Text <> "") Then        'checks if mark 1 input is empty
                If (markb.Text <> "") Then      'checks if mark 2 input is empty
                    If (markc.Text <> "") Then     'checks if mark 3 input is empty

                        'if all are not empty the below code runs
                        'try catch to handle user input errors
                        Try
                            markinputone = CInt(marka.Text)  ' cast user mark 1 input to the interger markinputone

                            state = "valid"                  'declares the state valid for controlling if all input is entered
                        Catch ex As Exception
                            'shows a message box if a char instead of a number is entered
                            MessageBox.Show("You entered a character instead of a number in mark1", "eroor")

                        End Try



                        Try

                            markinputtwo = CInt(markb.Text)    ' cast user mark 2 input to the interger markinputtwo

                            state = "valid"
                        Catch ex As Exception
                            MessageBox.Show("You entered a character instead of a number in mark2", "eroor")
                        End Try


                        Try

                            markinputthree = CInt(markc.Text)    ' cast user mark 3 input to the interger markinputhree
                            state = "valid"
                        Catch ex As Exception
                            MessageBox.Show("You entered a character instead of a number in mark3", "eroor")



                        End Try
                        'end of if statement.The statement above is used for confirming is user has filled in 
                        ' all inputs and that the user hasnt filled in a value that cant be used ie character



                    End If

                End If

            End If

        End If



        Try
            ' Below statements are used to check if input field for Mark 1 doesnt contain a value less than 0 or 
            ' a value above 100
            If markinputone < 0 Then
                MessageBox.Show("Mark one is less than 0", "error")
                state = ""    'will reset state to invalid so as not to run the calculation
            End If
            If markinputone > 100 Then
                MessageBox.Show("Mark one is Greater than than 100", "error")
                state = ""          'will reset state to invalid so as not to run the calculation
            End If
        Catch ex As Exception

        End Try



        Try
            ' Below statements are used to check if input field for Mark 2 doesnt contain a value less than 0 or 
            ' a value above 100
            If markinputtwo < 0 Then
                MessageBox.Show("Mark two is less than 0", "error")
                state = ""
            End If
            If markinputtwo > 100 Then
                MessageBox.Show("Mark two is Greater than than 100", "error")
                state = ""
            End If
        Catch ex As Exception

        End Try


        Try
            ' Below statements are used to check if input field for Mark 3 doesnt contain a value less than 0 or 
            ' a value above 100
            If markinputthree < 0 Then
                MessageBox.Show("Mark three is less than 0", "error")
                state = ""
            End If
            If markinputthree > 100 Then
                MessageBox.Show("Mark three is Greater than than 100", "error")
                state = ""
            End If
        Catch ex As Exception

        End Try


        If state = "valid" Then   'runs if all conditions are set ie state is initializes

            'gets the name and the three marks from user input
            Name = username.Text
            mark1 = marka.Text
            mark2 = markb.Text
            mark3 = markc.Text

            'clears the main listbox of all items that it contains
            listboxmain.Items.Clear()


            'adds the following items to the list box, name and mark 1,2,3 
            listboxmain.Items.Add("Student name: " & Name)
            listboxmain.Items.Add("Mark one: " & mark1)
            listboxmain.Items.Add("Mark two: " & mark2)
            listboxmain.Items.Add("Mark three: " & mark3)

            'numberone,numbertwo,numberthree are used to compare the size of the numbers entered by user
            'they store the int value of the inputs.
            Try
                numberone = CInt(mark1)
                numbertwo = CInt(mark2)
                numberthree = CInt(mark3)
            Catch ex As Exception

            End Try

            'The Mathd dot(.)Max function is used to find the biggest number among the three marks entered by the 
            'user.The biggest of each comparison is stored in the winnervariables /
            'the function below find the biggest number between mark 1 and mark 2
            winnerone = Math.Max(numberone, numbertwo)
            If numberone = winnerone Then
                firstwinner = numberone
                middle = numbertwo
                
            Else
                firstwinner = numbertwo
                middle = numberone
               
            End If
            'the function below find the biggest number between,( the results gotten by comparing Mark 1
            'and Mark 2 / the first winner)  and Mark 3.
            winnertwo = Math.Max(firstwinner, numberthree)
            If numberthree = winnertwo Then
                'Below if mark 3 is bigger than the result from the biggest number among mark 1 and mark 2
                'then Mark 3 is the biggest number among all
                finallwinner = numberthree
                middlewinner = firstwinner
                finallooser = middle


                'here the biggest number is result of biggest number between Mark 1 and Mark 2
                'listbocmain is listbox view in our form.and the code below adds items to it
                listboxmain.Items.Add("Largest Mark: " & finallwinner)
                listboxmain.Items.Add("Second Largest Mark : " & middlewinner)
                listboxmain.Items.Add("Smallest Mark: " & finallooser)
                'used to find the average and sum  of the top two biggest marks
                Dim average As Decimal = (finallwinner + middlewinner) / 2
                Dim sum As Integer = (finallwinner + middlewinner)

                'add sum and average to list box
                listboxmain.Items.Add("Sum: " & sum)
                listboxmain.Items.Add("Average Mark: " & average)


                '(Below) if Mark 3 is small then its compared to the smallest number gotten  from the result of mark1
                'and mark two. That Enables us to arrange the 1st 2nd and third number in order
            ElseIf winnertwo = firstwinner Then
                winnerthree = Math.Max(middle, numberthree)
                'here the biggest number between mark 3 and smalles of (mark 1 and mark 2) is Mark 3 thus 
                'the middle number is mark3
                If numberthree = winnerthree Then
                    finallwinner = firstwinner
                    middlewinner = numberthree
                    finallooser = middle


                ElseIf middle = winnerthree Then
                    finallwinner = firstwinner
                    middlewinner = middle
                    finallooser = numberthree

                End If



                'listbocmain is listbox view in our form.and the code below adds items to it
                listboxmain.Items.Add("Largest Mark: " & finallwinner)
                listboxmain.Items.Add("Second Largest Mark : " & middlewinner)
                listboxmain.Items.Add("Smallest Mark: " & finallooser)

                'used to find the average and sum  of the top two biggest marks
                Dim average As Decimal = (finallwinner + middlewinner) / 2
                Dim sum As Integer = (finallwinner + middlewinner)

                'add sum and average to list box
                listboxmain.Items.Add("Sum: " & sum)
                listboxmain.Items.Add("Average Mark: " & average)


            End If



        Else
            'Displays if an input field is found to be empty  by the if statements
            MessageBox.Show("Error: One of the input fields Has an Error!!.Please Confirm", "WARNING")
        End If

    End Sub

    Private Sub deletebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deletebtn.Click
        Try
            'deletes a selected item in the list box
            listboxmain.Items.RemoveAt(listboxmain.SelectedIndex)
        Catch ex As Exception

        End Try



    End Sub

    Private Sub marka_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles marka.TextChanged

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles username.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        group.Show()

    End Sub
End Class
