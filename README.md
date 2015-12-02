# Intex Prototype Web Portal

This is a prototype for the Fall 2015 INTEX exercise. 

### Sample Work Orders

**Work Order 1**
```json
{
  "WorkOrderID": 104729,
  "Comments": "",
  "DiscountPercent": 15,
  "TotalCharges": 1750.43,
  "CompoundName": "Phencyclidine",
  "MolecularMass": 243.387,
  "CompoundSamples": [{
    "CompoundSequenceCode": 1,
    "QtyInMilligrams": 50,
    "DateArrived": 2015-12-11,
    "DateDue": 2015-12-23,
    "Appearance": "",
    "ClaimedWeight": 124.184928,
    "ActualWeight": 124.184428,
    "MaximumToleratedDose": 300.000000
  }],
  "Assays": [{
    "AssayID": 7392,
    "AssayName": "PharmaScreen",
    "AssayProtocol": "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies",
    "DaysToCompletion": 2,
    "Tests": [{
      "RequiredTestID": 14893,
      "Name": "Sample Test 1",
      "Materials": [{
        "Name": "Gold",
        "Cost": 8473.23,
        "Quantity": 0.0001,
        "Results": [{
          "Quantitative": ,
          "Qualitative": ,
        }],
      },{
        "Name": "Silver",
        "Cost": 1564.34,
        "Quantity": 0.045
      }]
    },{
      "RequiredTestID": 39021,
      "Name": "Sample Test 2",
      "Materials": [{
        "Name": "Ammonium",
        "Cost": 0.03,
        "Quantity": 10
      },{
        "Name": "Silver",
        "Cost": 1564.34,
        "Quantity": 0.045
      }]
    },{
      "ConditionalTestID": 85920,
      "Name": "Sample Test 3",
      "Materials": [{
        "Name": "Iron",
        "Cost": 0.05,
        "Quantity": 2.0051
      },{
        "Name": "Lead",
        "Cost": 1.00,
        "Quantity": 1.65
      }],
      "LiteratureReferences": [{
        "LiteratureReferenceID": 9372,
        "Name": "Journal of Science",
        "Notes": "Pages 172-183"
      },{
        "LiteratureReferenceID": 8836,
        "Name": "Journal of Medical Science",
        "Notes": "Pages 32-67"
      }]
    }],
    "Data Report": "https://s3-us-west-2.amazonaws.com/northwestlabs/reports/data/104729.html",
    "Summary Report": "https://s3-us-west-2.amazonaws.com/northwestlabs/reports/summary/104729.html"
  }]
}
```
