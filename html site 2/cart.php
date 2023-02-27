<script src="js/jquery-3.6.3.min.js"> </script>
<?php
print_r($_GET);
include_once "header.php";
require_once "configDB.php";
?>

<div class="container">
		<div id="shopping-cart">
			<div class="txt-heading">
				<h1>Shopping cart</h1>
			</div>
			<a onClick="emptyCart()" id="btnEmpty">Empty Cart</a>
			<table class="tbl-cart" cellpadding="10" cellspacing="1">
				<thead>
					<tr>
						<th>Name</th>
						<th class='text-right' width="10%">Unit Price</th>
						<th class='text-right' width="5%">Quantity</th>
						<th class='text-right' width="10%">Sub Total</th>
					</tr>
				</thead>
				<tbody id="cartTableBody">
				</tbody>
				<tfoot>
					<tr>
						<td class="text-right">Total:</td>
						<td id="itemCount" class="text-right" colspan="2"></td>
						<td id="totalAmount" class="text-right"></td>
					</tr>
				</tfoot>
			</table>
		</div>
	</div>