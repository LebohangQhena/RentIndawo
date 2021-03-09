<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="indawo.register" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Registration</title>

    <!-- Font Icon -->
    <link rel="stylesheet" href="Registration/fonts/material-icon/css/material-design-iconic-font.min.css">

    <!-- Main css -->
    <link rel="stylesheet" href="Registration/css/style.css">
</head>
<body>
    
    <div class="main">

        <div class="container">
            <form method="POST" class="appointment-form"  runat="server">
                <h2>Registration</h2>
                <div class="form-group-1">
                    <input type="text" name="Name" id="txtname" placeholder="Name" runat="server" required />
                    <input type="text" name="Surname" id="txtSurname" placeholder="Surname" runat="server" required />
                    <input type="email" name="email" id="txtemail" placeholder="Email" runat="server" required />
                    <input type="number" name="phone_number" id="txtphone_number" placeholder="Phone number" runat="server" required />
                    <input type="password" name="password" id="txtpassword" placeholder="Password" runat="server" required />
                    <!--
                    <div class="select-list">
                        <select name="course_type" id="course_type">
                            <option slected value="">Course Type</option>
                            <option value="society">Society</option>
                            <option value="language">Language</option>
                        </select>
                    </div>
                        
                </div>
                <div class="form-group-2">
                    <h3>How would you like to bo located ?</h3>
                    <div class="select-list">
                        <select name="confirm_type" id="confirm_type">
                            <option seleected value="">By phone</option>
                            <option value="by_email">By email</option>
                        </select>
                    </div>
                    <div class="select-list">
                        <select name="hour_appointment" id="hour_appointment">
                            <option seleected value="">Hours : 8am 10pm</option>
                            <option value="9h-11h">Hours : 9am 11pm</option>
                        </select>
                    </div>
                </div>
                -->
                <div class="form-check">
                    <input type="checkbox" name="agree-term" id="agree-term" class="agree-term" />
                    <label for="agree-term" class="label-agree-term"><span><span></span></span>I agree to the  <a href="#" class="term-service">Terms and Conditions</a></label>
                </div>
                <div class="form-submit">
                    <asp:Button class="submit" text="Register" runat="server" OnClick="btnregister_Click" />
                    
                </div>
            </form>
        </div>

    </div>

    <!-- JS -->
    <script src="Registration/vendor/jquery/jquery.min.js"></script>
    <script src="Registration/js/main.js"></script>
</body><!-- This templates was made by Colorlib (https://colorlib.com) -->
</html>
