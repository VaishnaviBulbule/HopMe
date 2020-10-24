# Constants extracted from 2016 census dictionary
# Highest level of education
heap_values = {
    "100": "Postgraduate Degree",
    "110": "Postgraduate Degree",
    "111": "Postgraduate Degree",
    "120": "Postgraduate Degree",
    "200": "Graduate Diploma or Certificate",
    "211": "Graduate Diploma or Certificate",
    "221": "Graduate Diploma or Certificate",
    "222": "Graduate Diploma or Certificate",
    "300": "Bachelor Degree Level",
    "310": "Bachelor Degree Level",
    "400": "Advanced Diploma or Associate Degree",
    "411": "Advanced Diploma or Associate Degree",
    "413": "Advanced Diploma or Associate Degree",
    "421": "Diploma",
    "500": "Certificate III or IV",
    "511": "Certificate III or IV",
    "514": "Certificate III or IV",
    "521": "Certificate III or IV",
    "600": "Secondary School",
    "611": "Secondary School",
    "613": "Secondary School",
    "621": "Secondary School",
    "700": "Certificate I or II",
    "720": "Certificate I or II",
    "721": "Certificate I or II",
    "724": "Certificate I or II",
    "800": "Primary School",
    "811": "Primary School",
    "812": "Primary School",
    "998": "No education background",
    "001": "No education background"
}

# convert text to incremental values
heap_index_values = {
    "Postgraduate Degree": 9,
    "Graduate Diploma or Certificate": 8,
    "Bachelor Degree Level": 7,
    "Advanced Diploma or Associate Degree": 6,
    "Diploma": 5,
    "Certificate III or IV": 4,
    "Secondary School": 3,
    "Certificate I & II Level": 2,
    "Primary School": 1,
    "No education background": 0
}

# highest school year compeleted
# used to replace na values in heap
hscp_values = {
        '1': '611',
        '2': '613',
        '3': '621',
        '4': '811',
        '5': '812',
        '6': '998',
        'X': 'XXX'
}
# English proficiency
english_values = {
    "1": "Speaks English Only",
    "2": "Speaks English Very Well",
    "3": "Speaks English Well",
    "4": "Speaks English poorly",
    "5": "Do not speak English",
    "6": "Unknown English proficiency"
}
# text to numeric
english_index_values = {
    "Do not speak English": 0,
    "Speaks English poorly": 1,
    "Speaks English Well": 2,
    "Speaks English Very Well": 3,
    "Speaks English Only": 4
}
# field of study string to value
field_study_values = {
    'NO FIELD OF STUDY': 0,
    'NATURAL AND PHYSICAL SCIENCES': 1,
    'INFORMATION TECHNOLOGY': 2,
    'ENGINEERING AND RELATED TECHNOLOGIES': 3,
    'ARCHITECTURE AND BUILDING': 4,
    'AGRICULTURE, ENVIRONMENTAL AND RELATED STUDIES': 5,
    'HEALTH': 6,
    'EDUCATION': 7,
    'MANAGEMENT AND COMMERCE': 8,
    'SOCIETY AND CULTURE': 9,
    'CREATIVE ARTS': 10,
    'FOOD, HOSPITALITY AND PERSONAL SERVICES': 11,
    'MIXED FIELD PROGRAMMES': 12
}
